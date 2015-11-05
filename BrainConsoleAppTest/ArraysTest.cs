using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class ArraysTest
    {
        [TestMethod]
        public void SingleDimensionalArrayTest()
        {
            var items = new[] {1, 2, 3};
            Assert.AreEqual(3, items.Length);
            Assert.AreEqual(1, items.Rank);
            Assert.AreEqual(3, items.GetLength(0));
        }
        
        [TestMethod]
        public void ThreeDimensionalArrayTest()
        {
            var items = new [,]
            {
                {1, 2},
                {2, 3},
                {3, 4}
            };
            Assert.AreEqual(6, items.Length);
            Assert.AreEqual(2, items.Rank);

            Assert.AreEqual(3, items.GetLength(0));
            Assert.AreEqual(2, items.GetLength(1));
        }

        [TestMethod]
        public void JaggedArrayTest()
        {
            var items = new []
            {
                new [] {1, 2, 3},
                new [] {5},
                new [] {3, 4}
            };

            Assert.AreEqual(3, items[0][2]);
            Assert.AreEqual(3, items.Length);
            Assert.AreEqual(1, items.Rank);
            Assert.AreEqual(3, items.GetLength(0));
        }

        [TestMethod]
        public void FindLastItemTest()
        {
            // arrange
            var items = new[] {5, 2, 3, 4, 5};
            var itemIndex = 3;
            var itemToSearchFor = items[itemIndex];

            // act
            int lastIndex = items.Length - 1;
            for (; lastIndex >= 0; lastIndex--)
            {
                if (items[lastIndex] == itemToSearchFor)
                {
                    break;
                }
            }

            // assert
            Assert.AreEqual(itemIndex, lastIndex);

            var firstIndex = Array.IndexOf(items, lastIndex);
            Console.WriteLine(firstIndex);
            Assert.AreEqual(2, firstIndex);
        }

        [TestMethod]
        public void SortItemsTest()
        {
            var items = new[] {4, 5, 3, 2, 1};
            Array.Sort(items);

            Assert.AreEqual(1, items[0]);
            Assert.AreEqual(3, items[2]);
            Assert.AreEqual(5, items[4]);
        }

        [TestMethod]
        public void ArrayCopyTest()
        {
            var items = new[] {4, 5, 3, 2, 1};
            var copiedItems = new int[items.Length];

            Array.Copy(items, copiedItems, items.Length);

            Assert.AreEqual(items[0], copiedItems[0]);
            Assert.AreEqual(items[2], copiedItems[2]);
            Assert.AreEqual(items[4], copiedItems[4]);
        }
    }
}
