namespace BackpackProblemGUI
{
    partial class MainFrame
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
            System.Windows.Forms.Label BackpackSizeLabel;
            System.Windows.Forms.Label NumberOfItemsLabel;
            System.Windows.Forms.Label BackpackFillingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.StartButton = new System.Windows.Forms.Button();
            this.BackpackFillingBar = new System.Windows.Forms.ProgressBar();
            this.ListOfItemsBox = new System.Windows.Forms.TextBox();
            this.BackpackListBox = new System.Windows.Forms.TextBox();
            this.BackpackSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumberOfItemsUpDown = new System.Windows.Forms.NumericUpDown();
            this.FillingPercentageLabel = new System.Windows.Forms.Label();
            this.ArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.ItemsPictureBox = new System.Windows.Forms.PictureBox();
            this.BackpackPictureBox = new System.Windows.Forms.PictureBox();
            BackpackSizeLabel = new System.Windows.Forms.Label();
            NumberOfItemsLabel = new System.Windows.Forms.Label();
            BackpackFillingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackpackSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfItemsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackpackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackpackSizeLabel
            // 
            BackpackSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            BackpackSizeLabel.AutoSize = true;
            BackpackSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            BackpackSizeLabel.Location = new System.Drawing.Point(310, 14);
            BackpackSizeLabel.Name = "BackpackSizeLabel";
            BackpackSizeLabel.Size = new System.Drawing.Size(131, 20);
            BackpackSizeLabel.TabIndex = 5;
            BackpackSizeLabel.Text = "Rozmiar plecaka:";
            // 
            // NumberOfItemsLabel
            // 
            NumberOfItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            NumberOfItemsLabel.AutoSize = true;
            NumberOfItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            NumberOfItemsLabel.Location = new System.Drawing.Point(288, 46);
            NumberOfItemsLabel.Name = "NumberOfItemsLabel";
            NumberOfItemsLabel.Size = new System.Drawing.Size(153, 20);
            NumberOfItemsLabel.TabIndex = 6;
            NumberOfItemsLabel.Text = "Liczba przedmiotów:";
            // 
            // BackpackFillingLabel
            // 
            BackpackFillingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            BackpackFillingLabel.AutoSize = true;
            BackpackFillingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            BackpackFillingLabel.Location = new System.Drawing.Point(287, 419);
            BackpackFillingLabel.Name = "BackpackFillingLabel";
            BackpackFillingLabel.Size = new System.Drawing.Size(158, 20);
            BackpackFillingLabel.TabIndex = 10;
            BackpackFillingLabel.Text = "Wypełnienie plecaka:";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartButton.Location = new System.Drawing.Point(352, 74);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(80, 30);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // BackpackFillingBar
            // 
            this.BackpackFillingBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackpackFillingBar.Location = new System.Drawing.Point(451, 419);
            this.BackpackFillingBar.Name = "BackpackFillingBar";
            this.BackpackFillingBar.Size = new System.Drawing.Size(265, 20);
            this.BackpackFillingBar.Step = 1;
            this.BackpackFillingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BackpackFillingBar.TabIndex = 2;
            // 
            // ListOfItemsBox
            // 
            this.ListOfItemsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListOfItemsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListOfItemsBox.Location = new System.Drawing.Point(68, 163);
            this.ListOfItemsBox.Multiline = true;
            this.ListOfItemsBox.Name = "ListOfItemsBox";
            this.ListOfItemsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListOfItemsBox.Size = new System.Drawing.Size(265, 250);
            this.ListOfItemsBox.TabIndex = 8;
            // 
            // BackpackListBox
            // 
            this.BackpackListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackpackListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackpackListBox.Location = new System.Drawing.Point(451, 163);
            this.BackpackListBox.Multiline = true;
            this.BackpackListBox.Name = "BackpackListBox";
            this.BackpackListBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BackpackListBox.Size = new System.Drawing.Size(265, 250);
            this.BackpackListBox.TabIndex = 9;
            // 
            // BackpackSizeUpDown
            // 
            this.BackpackSizeUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackpackSizeUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackpackSizeUpDown.Location = new System.Drawing.Point(447, 12);
            this.BackpackSizeUpDown.Name = "BackpackSizeUpDown";
            this.BackpackSizeUpDown.Size = new System.Drawing.Size(49, 26);
            this.BackpackSizeUpDown.TabIndex = 11;
            this.BackpackSizeUpDown.ValueChanged += new System.EventHandler(this.BackpackSizeUpDown_ValueChanged);
            // 
            // NumberOfItemsUpDown
            // 
            this.NumberOfItemsUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfItemsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumberOfItemsUpDown.Location = new System.Drawing.Point(447, 44);
            this.NumberOfItemsUpDown.Name = "NumberOfItemsUpDown";
            this.NumberOfItemsUpDown.Size = new System.Drawing.Size(49, 26);
            this.NumberOfItemsUpDown.TabIndex = 12;
            this.NumberOfItemsUpDown.ValueChanged += new System.EventHandler(this.NumberOfItemsUpDown_ValueChanged);
            // 
            // FillingPercentageLabel
            // 
            this.FillingPercentageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FillingPercentageLabel.AutoSize = true;
            this.FillingPercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FillingPercentageLabel.Location = new System.Drawing.Point(722, 419);
            this.FillingPercentageLabel.Name = "FillingPercentageLabel";
            this.FillingPercentageLabel.Size = new System.Drawing.Size(32, 20);
            this.FillingPercentageLabel.TabIndex = 14;
            this.FillingPercentageLabel.Text = "0%";
            // 
            // ArrowPictureBox
            // 
            this.ArrowPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArrowPictureBox.Image = global::BackpackProblemGUI.Properties.Resources.right_arrow_icon;
            this.ArrowPictureBox.Location = new System.Drawing.Point(339, 247);
            this.ArrowPictureBox.Name = "ArrowPictureBox";
            this.ArrowPictureBox.Size = new System.Drawing.Size(106, 80);
            this.ArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowPictureBox.TabIndex = 13;
            this.ArrowPictureBox.TabStop = false;
            // 
            // ItemsPictureBox
            // 
            this.ItemsPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemsPictureBox.Image = global::BackpackProblemGUI.Properties.Resources.item_icon;
            this.ItemsPictureBox.Location = new System.Drawing.Point(153, 72);
            this.ItemsPictureBox.Name = "ItemsPictureBox";
            this.ItemsPictureBox.Size = new System.Drawing.Size(80, 85);
            this.ItemsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemsPictureBox.TabIndex = 4;
            this.ItemsPictureBox.TabStop = false;
            // 
            // BackpackPictureBox
            // 
            this.BackpackPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackpackPictureBox.Image = global::BackpackProblemGUI.Properties.Resources.backpack_icon;
            this.BackpackPictureBox.Location = new System.Drawing.Point(546, 72);
            this.BackpackPictureBox.Name = "BackpackPictureBox";
            this.BackpackPictureBox.Size = new System.Drawing.Size(84, 85);
            this.BackpackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackpackPictureBox.TabIndex = 3;
            this.BackpackPictureBox.TabStop = false;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.FillingPercentageLabel);
            this.Controls.Add(this.ArrowPictureBox);
            this.Controls.Add(this.NumberOfItemsUpDown);
            this.Controls.Add(this.BackpackSizeUpDown);
            this.Controls.Add(BackpackFillingLabel);
            this.Controls.Add(this.BackpackListBox);
            this.Controls.Add(this.ListOfItemsBox);
            this.Controls.Add(NumberOfItemsLabel);
            this.Controls.Add(BackpackSizeLabel);
            this.Controls.Add(this.ItemsPictureBox);
            this.Controls.Add(this.BackpackPictureBox);
            this.Controls.Add(this.BackpackFillingBar);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "Backpack Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackpackSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfItemsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackpackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar BackpackFillingBar;
        private System.Windows.Forms.PictureBox BackpackPictureBox;
        private System.Windows.Forms.PictureBox ItemsPictureBox;
        private System.Windows.Forms.TextBox ListOfItemsBox;
        private System.Windows.Forms.TextBox BackpackListBox;
        private System.Windows.Forms.NumericUpDown BackpackSizeUpDown;
        private System.Windows.Forms.NumericUpDown NumberOfItemsUpDown;
        private System.Windows.Forms.PictureBox ArrowPictureBox;
        private System.Windows.Forms.Label FillingPercentageLabel;
    }
}

