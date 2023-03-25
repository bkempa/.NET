using BackpackProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BackpackProblemUnitTests
{
    [TestClass]
    public class BackpackTests
    {
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

    }
}
