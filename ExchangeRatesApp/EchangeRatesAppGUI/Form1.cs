using ExchangeRatesConsoleApp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using System.Linq;

namespace ExchangeRatesAppGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart.Visible = false;
            this.Size = new Size(719, 309);
            startDatePicker.MaxDate = DateTime.Today;
            startDatePicker.Value = DateTime.Today;
            startButton.Enabled = false;
            currenciesOutput.TabPages.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            currenciesOutput.Controls.Clear();

            var context = new CurrenciesDatabase();
            context.Currencies.RemoveRange(context.Currencies);
            HttpClient client = new HttpClient();
            string call, chosenDate;
            List<string> currencyCodes = new List<string>();
            chosenDate = startDatePicker.Value.ToString("yyyy-MM-dd");

            foreach (var currency in currenciesCheckedListBox.CheckedItems)
                currencyCodes.Add(currency.ToString().Substring(0, 3));

            bool ifOneCurrencyChosen = (currencyCodes.Count == 1);

            if (!ifOneCurrencyChosen)
            {
                this.Size = new Size(719, 615);
                chart.Titles.Clear();
                chart.Controls.Clear();
                chart.Series.Clear();
                chart.Titles.Add("Stan na dzień " + startDatePicker.Value.ToShortDateString());
                chart.Series.Add("Currencies");
            } 

            Color[] colors = {Color.Green, Color.Blue, Color.Red, Color.Orange, Color.Yellow, Color.Brown, Color.Purple, Color.Pink};
            int i = 0;

            foreach (string currencyCode in currencyCodes)
            {
                Currency currencyFromBase = (from c in context.Currencies
                                             where c.CurrencyCode == currencyCode && c.Rates.EffectiveDate == startDatePicker.Value.Date
                                             select c).SingleOrDefault();

                TabPage tabPage = new TabPage(currencyCode);
                currenciesOutput.TabPages.Add(tabPage);
                TextBox textBox = new TextBox
                {
                    ScrollBars = ScrollBars.Vertical,
                    Multiline = true,
                    Size = new Size(currenciesOutput.Size.Width - 5, currenciesOutput.Size.Height - 23)
                };
                tabPage.Controls.Add(textBox);

                if (currencyFromBase == null)
                {
                    call = $"http://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}/{chosenDate}/?format=json";
                    var response = await client.GetAsync(call);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        Currency currency = JsonConvert.DeserializeObject<Currency>(responseString);
                        context.Currencies.Add(currency);
                        context.SaveChanges();
                        textBox.Text = currency.ToString();

                        if (!ifOneCurrencyChosen)
                        {
                            chart.Visible = true;
                            chart.Series["Currencies"].IsVisibleInLegend = false;
                            chart.Series["Currencies"].Points.AddXY(currencyCode, currency.Rates.Mid);
                            chart.Series["Currencies"].Points[i].Color = colors[i % colors.Length];
                            chart.Series["Currencies"].Points[i].Label = currency.Rates.Mid.ToString();
                            i++;
                        }
                    }
                    else
                    {
                        chart.Visible = false;
                        this.Size = new Size(719, 309);
                        textBox.Text = "Brak danych dla podanego przedziału czasowego";
                    }
                }
                else
                {
                    textBox.Text = currencyFromBase.ToString();
                    if (!ifOneCurrencyChosen)
                    {
                        chart.Visible = true;
                        chart.Series["Currencies"].IsVisibleInLegend = false;
                        chart.Series["Currencies"].Points.AddXY(currencyCode, currencyFromBase.Rates.Mid);
                        chart.Series["Currencies"].Points[i].Color = colors[i % colors.Length];
                        chart.Series["Currencies"].Points[i].Label = currencyFromBase.Rates.Mid.ToString();
                        i++;
                    }
                }
            }
        }

        private void getFromTodayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (getFromTodayCheckBox.Checked)
            {
                startDatePicker.Value = DateTime.Now.Date;
                startDatePicker.Enabled = false;
            }
            else
                startDatePicker.Enabled = true;
        }

        private void currenciesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currenciesCheckedListBox.CheckedItems.Count > 0)
                startButton.Enabled = true;
            else
                startButton.Enabled = false;
        }
    }
}
