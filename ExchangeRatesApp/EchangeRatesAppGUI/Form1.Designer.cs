namespace ExchangeRatesAppGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startButton = new System.Windows.Forms.Button();
            this.getFromTodayCheckBox = new System.Windows.Forms.CheckBox();
            this.currenciesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.currenciesOutput = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            startDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.currenciesOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(8, 68);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(69, 13);
            startDateLabel.TabIndex = 8;
            startDateLabel.Text = "Wybierz datę";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(231, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 13);
            label1.TabIndex = 12;
            label1.Text = "Wybór walut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(535, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 13);
            label2.TabIndex = 13;
            label2.Text = "Kursy walut";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(11, 84);
            this.startDatePicker.MinDate = new System.DateTime(2002, 1, 2, 0, 0, 0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(141, 20);
            this.startDatePicker.TabIndex = 0;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(11, 270);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(679, 294);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(44, 133);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Wyświetl";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // getFromTodayCheckBox
            // 
            this.getFromTodayCheckBox.AutoSize = true;
            this.getFromTodayCheckBox.Location = new System.Drawing.Point(11, 110);
            this.getFromTodayCheckBox.Name = "getFromTodayCheckBox";
            this.getFromTodayCheckBox.Size = new System.Drawing.Size(137, 17);
            this.getFromTodayCheckBox.TabIndex = 5;
            this.getFromTodayCheckBox.Text = "Wyświetl dzisiejszy kurs";
            this.getFromTodayCheckBox.UseVisualStyleBackColor = true;
            this.getFromTodayCheckBox.CheckedChanged += new System.EventHandler(this.getFromTodayCheckBox_CheckedChanged);
            // 
            // currenciesCheckedListBox
            // 
            this.currenciesCheckedListBox.CheckOnClick = true;
            this.currenciesCheckedListBox.FormattingEnabled = true;
            this.currenciesCheckedListBox.Items.AddRange(new object[] {
            "USD - dolar amerykański",
            "EUR - euro",
            "GBP - funt szterling",
            "CHF - frank szwajcarski",
            "CZK - korona czeska",
            "HUF - forint (Węgry)",
            "UAH - hrywna (Ukraina)",
            "AUD - dolar australijski",
            "CAD - dolar kanadyjski",
            "DKK - korona duńska",
            "ISK - korona islandzka",
            "NOK - korona norweska",
            "SEK - korona szwedzka",
            "RON - lej rumuński",
            "BGN - lew (Bułgaria)",
            "TRY - lira turecka",
            "JPY - jen (Japonia)",
            "HKD - dolar Hongkongu",
            "NZD - dolar nowozelandzki",
            "SGD - dolar singapurski",
            "THB - bat (Tajladnia)",
            "ILS - nowy izrealski szekel",
            "CLP - peso chilijskie",
            "PHP - peso filipińskie",
            "MXN - peso meksykańskie",
            "ZAR - rand (RPA)",
            "BRL - real (Brazylia)",
            "MYR - ringgit (Malezja)",
            "IDR - rupia indonezyjska",
            "INR - rupia indyjska",
            "KRW - won południowokoreański",
            "CNY - yuan renminbi (Chiny)"});
            this.currenciesCheckedListBox.Location = new System.Drawing.Point(165, 25);
            this.currenciesCheckedListBox.Name = "currenciesCheckedListBox";
            this.currenciesCheckedListBox.Size = new System.Drawing.Size(203, 229);
            this.currenciesCheckedListBox.TabIndex = 10;
            this.currenciesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.currenciesCheckedListBox_SelectedIndexChanged);
            // 
            // currenciesOutput
            // 
            this.currenciesOutput.Controls.Add(this.tabPage1);
            this.currenciesOutput.Controls.Add(this.tabPage2);
            this.currenciesOutput.Location = new System.Drawing.Point(449, 25);
            this.currenciesOutput.Name = "currenciesOutput";
            this.currenciesOutput.SelectedIndex = 0;
            this.currenciesOutput.Size = new System.Drawing.Size(241, 229);
            this.currenciesOutput.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(233, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(233, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 576);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.currenciesOutput);
            this.Controls.Add(this.currenciesCheckedListBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.getFromTodayCheckBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.startDatePicker);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursy walut";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.currenciesOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox getFromTodayCheckBox;
        private System.Windows.Forms.CheckedListBox currenciesCheckedListBox;
        private System.Windows.Forms.TabControl currenciesOutput;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

