using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.Exceptions
{
    [TestClass]
    public class ArithmeticExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void SummingCheckedExceptionTest()
        {
            checked
            {
                var result = int.MaxValue;
                result++;
            }
        }
    }
}
