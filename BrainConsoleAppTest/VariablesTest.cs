using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void SumTest()
        {
            var t = new List<Qwerty>();
            t.Add(new Qwerty{amount = 3});
            t.Add(new Qwerty{amount = 5});

            Assert.AreEqual(8, t.Sum(item => item.amount));
        }
    }

    public struct Qwerty
    {
        public int amount;
    }
}
