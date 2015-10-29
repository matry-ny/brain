using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    public enum Result
    {
        Sussess = 0,
        Fail = 1
    }

    [TestClass]
    public class EnumTest
    {
        [TestMethod]
        public void enumTest1()
        {
            var result = default(Result);
            Debug.WriteLine(result);
        }

        [TestMethod]
        public void equalityTest()
        {
            var result = Result.Fail;
            Assert.AreNotEqual(Result.Sussess, result);
        }

        [TestMethod]
        public void typeEqualityTest()
        {
            var result = Result.Fail;
            Assert.AreSame(typeof(Result), result.GetType());
        }

        [TestMethod]
        public void parseFromStringWorksTest()
        {
            var expected = Result.Sussess;
            var stringResult = expected.ToString();

            Result parsed;
            var result = Enum.TryParse(stringResult, out parsed);

            Assert.IsTrue(result);
            Assert.AreEqual(expected, parsed);
        }
    }
}
