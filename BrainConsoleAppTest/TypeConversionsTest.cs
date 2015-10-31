using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class TypeConversionsTest
    {
        private long longArgument = 1;
        private short shortArgument = 2;
        private int intArgument = 3;

        [TestMethod]
        public void AutomaticExpressionConversionTest()
        {
            var calculationResult = this.intArgument + this.shortArgument + this.longArgument;
            Assert.AreSame(longArgument.GetType(), calculationResult.GetType());
        }

        [TestMethod]
        public void ManualExpressionConversionTest()
        {
            var calculationResult = this.intArgument + this.shortArgument + (short)this.longArgument;
            Assert.AreSame(intArgument.GetType(), calculationResult.GetType());
        }

        [TestMethod]
        public void IncompatibleExpressionConversionTest()
        {
            int x = 1;
            int y = 2;

            var calculationResult = x / y;
            Console.WriteLine(calculationResult);
        }
    }
}
