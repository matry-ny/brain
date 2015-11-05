using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class ConvertTest
    {
        [TestMethod]
        public void ToInt32Test()
        {
            var startNumber = 123.3m;
            var culture = CultureInfo.CurrentCulture;
            var simpleString = startNumber.ToString(culture);

            var value = Convert.ToDecimal(simpleString, culture);
            Assert.AreEqual(startNumber, value);
        }
    }
}
