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
            var apple = new Apple(FruitColor.Green);

            // common Fruit assert
            apple.CheckExpirationContract();

            // custom Fruit Assert
            Assert.AreEqual(FruitColor.Brown, apple.Color);
        }
    }
}
