using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class OperatorsTest
    {
        [TestMethod]
        public void DoubleIncrementTest()
        {
            var testNumber = 0;
            testNumber++;
            ++testNumber;
            Assert.AreEqual(2, testNumber);
        }

        [TestMethod]
        public void ComplexDoubleIncrementTest()
        {
            var testNumber = 0;
            var sufficsed = testNumber++;
            Assert.AreEqual(0, sufficsed);

            var otherTestNumber = 0;
            var prefixed = ++otherTestNumber;
            Assert.AreEqual(1, prefixed);
        }
    }
}
