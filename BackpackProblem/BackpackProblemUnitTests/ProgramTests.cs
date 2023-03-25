using BackpackProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BackpackProblemUnitTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateNegativeNumberOfItems()
        {
            Program.CreateItems(-5);
        }

        [TestMethod]
        public void CreateItemsTest()
        {
            Assert.AreEqual(5, Program.CreateItems(5).Count);
        }

        [TestMethod]
        public void SortItems()
        {
            Item item1 = new Item(3, 4);    //0.75
            Item item2 = new Item(2, 1);    //2
            Item item3 = new Item(4, 5);    //0.8
            Item item4 = new Item(8, 1);    //8
            Item item5 = new Item(6, 4);    //1.5
            List<Item> items = new List<Item>
            {
                item1, item2, item3, item4, item5
            };
            List<Item> expected = new List<Item>
            {
                item4, item2, item5, item3, item1
            };
            Program.SortItems(items);
            Assert.IsTrue(expected.SequenceEqual(items));
        }

    }
}
