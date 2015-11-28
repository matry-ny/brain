using System;
using BrainConsoleApp.OOP.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.Methods
{
    [TestClass]
    public class StringFormatterTest
    {
        [TestMethod]
        public void VersionTest()
        {
            var result = (new StringFormatter()).GetVersion();
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void MakeIntTest()
        {
            var result = (new StringFormatter()).MakeInt("---{0}---", 43);
            string expected = "---43---";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void MakeFigureTest()
        {
            var formatter = new StringFormatter();
           
            var w = 54;
            var h = 33;
            var result = formatter.MakeFigure(h, w);
            Assert.AreEqual(result, String.Format(StringFormatter.FigureFormat, StringFormatter.Rectagle, w, h));

            w = 10;
            h = 10;
            result = formatter.MakeFigure(width: w, height: h);
            Assert.AreEqual(result, String.Format(StringFormatter.FigureFormat, StringFormatter.Square, w, h));
        }

        [TestMethod]
        public void MakeIntegersLineTest()
        {
            var formatter = new StringFormatter();

            var result = formatter.MakeIntegersLine("[{0}]", ',', 1, 44, 66, 982, 666);
            Assert.AreEqual("[1],[44],[66],[982],[666]", result);

            result = formatter.MakeIntegersLine("{0}");
            Assert.IsTrue(String.IsNullOrEmpty(result));

            result = formatter.MakeIntegersLine("{0}", '|');
            Assert.IsTrue(String.IsNullOrEmpty(result));

            result = formatter.MakeIntegersLine("{0}", integers: new []{0, 1, 2, 3});
            Assert.AreEqual("0;1;2;3", result);
        }
    }
}
