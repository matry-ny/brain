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

        [TestMethod]
        public void isOperatorTest()
        {
            var testString = "Test string";
            var isDoubleValue = testString is Double;
            Assert.IsFalse(isDoubleValue);

            var isStringValue = testString is String;
            Assert.IsTrue(isStringValue);
        }

        [TestMethod]
        public void asOperatorTest()
        {
            object value = 123d;
            var isStringValue = value as String;
            Assert.IsNull(isStringValue);

            var expected = "Tests";
            object otherValue = expected;
            var isNowStringValue = otherValue as String;

            Assert.IsNotNull(isNowStringValue);
            Assert.AreEqual(expected, otherValue);
        }

        [TestMethod]
        public void coalesceOperatorTest()
        {
            var defaultValue = "Test";
            string customValue = null;

            customValue = customValue ?? defaultValue;
            Console.WriteLine(customValue);
            Assert.AreEqual(defaultValue, customValue);

            var test = 1;
            if (test != 2)
            {
                Console.WriteLine("OK");
            }
        }
    }
}
