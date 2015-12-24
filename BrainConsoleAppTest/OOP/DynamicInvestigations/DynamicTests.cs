using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.DynamicInvestigations
{
    [TestClass]
    public class DynamicTests
    {
        [TestMethod]
        public void GoodExampleTest()
        {
            dynamic a = new object();
            a.Name = "test";

            Assert.AreEqual("123", a.Name);
        }
    }
}
