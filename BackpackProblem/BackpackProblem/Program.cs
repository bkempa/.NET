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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbe przedmiotow: ");
            int n = int.Parse(Console.ReadLine());
            List<Item> items = CreateItems(n);

            Console.WriteLine("Przedmioty:");
            Console.WriteLine(string.Join("\n", items));

            Console.Write("Podaj pojemnosc plecaka: ");
            int backpack_size = int.Parse(Console.ReadLine());
            Backpack backpack = new Backpack(backpack_size);

            SortItems(items);
            backpack.AddToBackpack(items);

            Console.WriteLine("Plecak:");
            Console.WriteLine(backpack);
            Console.Read();
        }

        public static List<Item> CreateItems(int number)
        {
            if (number >= 0)
            {
                List<Item> items = new List<Item>();
                Random rand = new Random();
                for (int i = 0; i < number; i++)
                    items.Add(new Item(rand.Next(1, 9), rand.Next(1, 9)));
                return items;
            }
            else
                throw new ArgumentOutOfRangeException("Number of created items has to be positive");
        }

        public static void SortItems(List<Item> items)
        {
            items.Sort((x, y) => y.CompareTo(x));
        }
    }
}
