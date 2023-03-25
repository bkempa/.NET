using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackpackProblem;

namespace BackpackProblemGUI
{
    public partial class MainFrame : Form
    {
        private int backpack_size;
        private int number_of_items;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            List<Item> items = BackpackProblem.Program.CreateItems(number_of_items);
            Backpack backpack = new Backpack(backpack_size);

            BackpackProblem.Program.SortItems(items);
            backpack.AddToBackpack(items);

            ListOfItemsBox.Text = string.Join(Environment.NewLine, items);
            BackpackListBox.Text = backpack.ToString();

            int current_filling = 0;
            foreach (Item item in backpack.Items)
                current_filling += item.Value * item.Weight;
            double filling = (double)current_filling / (double)backpack_size;
            FillingPercentageLabel.Text = String.Format("{0:0.#}", (filling * 100)) + "%";
            BackpackFillingBar.Value = (int)(filling*100);
            BackpackFillingBar.PerformStep();
        }

        private void NumberOfItemsUpDown_ValueChanged(object sender, EventArgs e)
        {
            number_of_items = (int)NumberOfItemsUpDown.Value;
        }

        private void BackpackSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            backpack_size = (int)BackpackSizeUpDown.Value;
        }
    }
}
