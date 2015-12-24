using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.Enumerables
{
    [TestClass]
    public class EnumerableTests
    {
        [TestMethod]
        public void SumValuesFromEnumeratorTest()
        {
            var collectionTest = new[] { 1, 2, 3};
            var enumerator = collectionTest.GetEnumerator();
            int sum = 0;

            while (enumerator.MoveNext())
            {
                sum += (int)enumerator.Current;
            }

            Assert.AreEqual(1 + 2 + 3, sum);
        }
    }
}
