using BackpackProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("BackpackProblemGUI"), InternalsVisibleTo("BackpackProblemUnitTests")]
namespace BackpackProblem
{
    internal class Backpack
    {
        public List<Item> Items { get; }
        readonly int Capacity;

        public Backpack(int size)
        {
            if (size > 0)
            {
                Items = new List<Item>();
                Capacity = size;
            }
            else
                throw new ArgumentOutOfRangeException("Backpack's capacity has to be a positive number");
        }

        public override string ToString()
        {
            string str = "";
            foreach (Item i in Items)
                str += i + "\n";
            return str;
        }

        public void AddToBackpack(List<Item> itemsToPack)
        {
            int currentCost = 0;
            foreach (Item item in itemsToPack)
            {
                currentCost += item.Weight * item.Value;
                if (currentCost <= Capacity)
                    Items.Add(item);
                else
                    continue;
            }
        }
    }
}
