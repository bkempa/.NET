using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BackpackProblem;
using System.Collections.Generic;
using System.Linq;

namespace BackpackProblemUnitTests
{
    [TestClass]
    public class ItemTests
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
    }
}
