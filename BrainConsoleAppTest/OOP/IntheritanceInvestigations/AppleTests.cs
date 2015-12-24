using System;
using BrainConsoleApp.OOP.IntheritanceInvestigations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.IntheritanceInvestigations
{
    [TestClass]
    public class AppleTests
    {
        [TestMethod]
        public void TestAppleExpiration()
        {
            var apple = new Apple(AppleColorPalette.Good);

            // common Fruit assert
            apple.CheckExpirationContract();

            // custom Fruit Assert
            Assert.AreEqual(AppleColorPalette.Expired, apple.Color);
        }
    }
}
