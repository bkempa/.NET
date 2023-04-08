using ExchangeRatesConsoleApp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace ExchangeRatesAppGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart.Visible = false;
            this.Size = new Size(719, 309);
            endDatePicker.MaxDate = DateTime.Today;
            startDatePicker.MaxDate = DateTime.Today;

            endDatePicker.Value = DateTime.Today;
            startDatePicker.Value = DateTime.Today;

            endDatePicker.MinDate = DateTime.Today;
            startButton.Enabled = false;
            currenciesOutput.TabPages.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.MinDate = startDatePicker.Value.Date;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            if (CheckIfPeriodLongerThan91Days())
                return;
            this.Size = new Size(719, 615);
            chart.Visible = true;
            chart.Titles.Clear();
            chart.Controls.Clear();
            chart.Series.Clear();
            currenciesOutput.Controls.Clear();

            HttpClient client = new HttpClient();
            string call, startDate, endDate;
            List<string> currencyCodes = new List<string>();
            startDate = startDatePicker.Value.ToString("yyyy-MM-dd");
            endDate = endDatePicker.Value.ToString("yyyy-MM-dd");

            foreach (var currency in currenciesCheckedListBox.CheckedItems)
                currencyCodes.Add(currency.ToString().Substring(0, 3));

            bool ifShowOneDay = startDate.Equals(endDate);
            bool ifOneCurrencyChosen = (currencyCodes.Count == 1);

            if (ifShowOneDay && !ifOneCurrencyChosen)
            {
                chart.Titles.Add("Stan na dzień " + startDatePicker.Value.ToShortDateString());
                chart.Series.Add("Currencies");
            } 

            Color[] colors = {Color.Green, Color.Blue, Color.Red, Color.Orange, Color.Yellow, Color.Brown, Color.Purple, Color.Pink};
            int i = 0;

            foreach (string currencyCode in currencyCodes)
            {
                TabPage tabPage = new TabPage(currencyCode);
                currenciesOutput.TabPages.Add(tabPage);
                TextBox textBox = new TextBox
                {
                    ScrollBars = ScrollBars.Vertical,
                    Multiline = true,
                    Size = new Size(currenciesOutput.Size.Width - 5, currenciesOutput.Size.Height - 23)
                };
                tabPage.Controls.Add(textBox);

                call = $"http://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}/{startDate}/{endDate}/?format=json";
                var response = await client.GetAsync(call);

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    Currency currency = JsonConvert.DeserializeObject<Currency>(responseString);
                    textBox.Text = currency.ToString();

                    if (ifShowOneDay && !ifOneCurrencyChosen)
                    {
                        chart.Series["Currencies"].IsVisibleInLegend = false;
                        chart.Series["Currencies"].Points.AddXY(currencyCode, currency.Rates[0].Mid);
                        chart.Series["Currencies"].Points[i].Color = colors[i % colors.Length];
                        chart.Series["Currencies"].Points[i].Label = currency.Rates[0].Mid.ToString();
                        i++;
                    }
                    else if (ifShowOneDay && ifOneCurrencyChosen)
                    {
                        string[] period = FindTimePeriod();
                        call = $"http://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}/{period[0]}/{period[1]}/?format=json";
                        response = await client.GetAsync(call);

                        if (response.IsSuccessStatusCode)
                        {
                            responseString = await response.Content.ReadAsStringAsync();
                            currency = JsonConvert.DeserializeObject<Currency>(responseString);

                            chart.Titles.Add("Kurs na przestrzeni 14 dni");
                            chart.Series.Add(currencyCode);
                            chart.Series[currencyCode].IsVisibleInLegend = false;
                            chart.Series[currencyCode].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                            foreach (Rate rate in currency.Rates)
                                chart.Series[currencyCode].Points.AddXY(rate.EffectiveDate, rate.Mid);
                        }
                        else
                            chart.Enabled = false;
                    }
                    else if (!ifShowOneDay)
                    {
                        chart.Series.Add(currencyCode);
                        if (ifOneCurrencyChosen)
                            chart.Series[currencyCode].IsVisibleInLegend = false;
                        chart.Series[currencyCode].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        foreach (Rate rate in currency.Rates)
                            chart.Series[currencyCode].Points.AddXY(rate.EffectiveDate, rate.Mid);
                    }
                }
                else
                    textBox.Text = "Brak danych dla podanego przedziału czasowego";
            }
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startDatePicker.MaxDate = endDatePicker.Value;
        }

        private void getFromTodayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (getFromTodayCheckBox.Checked)
            {
                endDatePicker.Value = DateTime.Now.Date;
                startDatePicker.Value = DateTime.Now.Date;
                startDatePicker.Enabled = false;
                endDatePicker.Enabled = false;
            }
            else
            {
                startDatePicker.Enabled = true;
                endDatePicker.Enabled = true;
            }
        }

        private void currenciesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currenciesCheckedListBox.CheckedItems.Count > 0)
                startButton.Enabled = true;
            else
                startButton.Enabled = false;
        }

        private bool CheckIfPeriodLongerThan91Days()
        {
            if (startDatePicker.Value.AddDays(93) < endDatePicker.Value)
            {
                string message = "Ustawiony przedział czasowy jest zbyt długi (max 93 dni)\n" +
                    "\tOpcja 1: " + startDatePicker.Value.ToShortDateString() + " - " + startDatePicker.Value.Date.AddDays(93).ToShortDateString() +
                    "\n\tOpcja 2: " + endDatePicker.Value.Date.AddDays(-93).ToShortDateString() + " - " + endDatePicker.Value.ToShortDateString();
                string title = "Błąd";
                MessageBox.Show(message, title);
                return true;
            }
            else { return false; }
        }

        private string[] FindTimePeriod()
        {
            DateTime givenDate = startDatePicker.Value.Date;
            DateTime today = DateTime.Today;
            DateTime minDate = new DateTime(2002, 2, 2);
            int maxDays = 7;

            DateTime startDate = givenDate.AddDays(-maxDays);
            if (startDate < minDate)
                startDate = minDate;

            int days = (int)(givenDate - startDate).TotalDays;

            DateTime endDate = givenDate.AddDays(maxDays);
            if (endDate > today)
                endDate = today;

            int daysToEnd = (int)(endDate - givenDate).TotalDays;

            if (daysToEnd + days < 14)
            {
                int daysToAdd = 14 - (daysToEnd + days);
                if (daysToEnd < 7)
                {
                    startDate = givenDate.AddDays(-daysToAdd);
                    if (startDate < minDate)
                    {
                        startDate = minDate;
                        endDate = startDate.AddDays(14);
                    }
                    else
                        endDate = givenDate.AddDays(7);
                }
                else if (days < 7)
                {
                    endDate = givenDate.AddDays(daysToAdd);
                    if (endDate > today)
                    {
                        endDate = today;
                        startDate = endDate.AddDays(-14);
                    }
                    else
                        startDate = givenDate.AddDays(-7);
                }
            }

            if (startDate.AddDays(14) > today)
            {
                endDate = today;
                startDate = endDate.AddDays(-14);
            }

            if (endDate < minDate.AddDays(14))
            {
                startDate = minDate;
                endDate = startDate.AddDays(14);
            }
            return new string[] { startDate.Date.ToString("yyyy-MM-dd"), endDate.Date.ToString("yyyy-MM-dd") };
        }
    }
}
