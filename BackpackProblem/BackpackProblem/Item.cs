using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("BackpackProblemGUI"), InternalsVisibleTo("BackpackProblemUnitTests")]

namespace BackpackProblem
{
    internal class Item : IComparable
    {
        public int Value { get; set; }
        public int Weight { get; set; }

        public Item(int value, int cost)
        {
            if (value > 0 && cost > 0)
            {
                this.Value = value;
                this.Weight = cost;
            }
            else
                throw new ArgumentOutOfRangeException("Item's value and cost have to be positive numbers");
        }

        public int CompareTo(object obj)
        {
            Item item = obj as Item;
            double val = (double)this.Value / (double)this.Weight;
            double val2 = (double)item.Value / (double)item.Weight;
            return val.CompareTo(val2);
        }

        public override string ToString()
        {
            return "value: " + Value + ", weight: " + Weight + ", profit = " + String.Format("{0:0.###}", (double)Value / (double)Weight);
        }
    }
}
