using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BackpackProblem;
using System.Collections.Generic;
using System.Linq;

namespace BackpackProblemUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IllegalArgumentItemConstructor()
        {
            Item item = new Item(-3, 5);
        }

        [TestMethod]
        public void EqualItems()
        {
            Item item1 = new Item(10, 2);
            Item item2 = new Item(25, 5);
            Assert.AreEqual(0, item1.CompareTo(item2));
        }

        [TestMethod]
        public void NotEqualItems()
        {
            Item item1 = new Item(10, 2);
            Item item2 = new Item(20, 5);
            Assert.AreEqual(1, item1.CompareTo(item2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IllegalArgumentBackpackConstructor()
        {
            Backpack backpack = new Backpack(-3);
        }

        [TestMethod]
        public void AddToBackpackTest()
        {
            Backpack backpack = new Backpack(20);
            Item item1 = new Item(3, 4);
            Item item2 = new Item(2, 1);
            Item item3 = new Item(4, 5);
            Item item4 = new Item(8, 1);
            Item item5 = new Item(6, 3);
            List<Item> items = new List<Item>
            {
                item1, item2, item3, item4, item5
            };
            backpack.AddToBackpack(items);
            Assert.AreEqual(2, backpack.Items.Count);
            Assert.IsTrue(backpack.Items.Contains(item1) && backpack.Items.Contains(item2));
        }

        [TestMethod]
        public void NothingToAddToBackpackTest()
        {
            Backpack backpack = new Backpack(1);
            Item item1 = new Item(3, 4);
            Item item2 = new Item(2, 1);
            Item item3 = new Item(4, 5);
            Item item4 = new Item(8, 1);
            Item item5 = new Item(6, 3);
            List<Item> items = new List<Item>
            {
                item1, item2, item3, item4, item5
            };
            backpack.AddToBackpack(items);
            Assert.AreEqual(0, backpack.Items.Count);
        }

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
