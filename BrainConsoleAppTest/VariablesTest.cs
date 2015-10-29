using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class VariablesTest
    {
        [TestMethod]
        public void doubleDeclarationTest()
        {
            double typeDouble = 1.2;
            var dType = 0.3d;

            Assert.AreNotEqual(typeDouble, dType);
        }

        [TestMethod]
        public void intDeclarationTest()
        {
            var integerValue = new int();
            var integer = new Int32();
            Assert.AreEqual(integerValue, integer);
        }

        [TestMethod]
        public void chainedDeclarationTest()
        {
            char test = 'e';
            test = 'r';
            Assert.AreEqual(test, 'r');
        }
    }
}
