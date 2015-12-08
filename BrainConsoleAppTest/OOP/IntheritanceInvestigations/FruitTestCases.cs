using System;
using BrainConsoleApp.OOP.IntheritanceInvestigations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.IntheritanceInvestigations
{
    [TestClass]
    public static class FruitTestCases
    {
        [TestMethod]
        public static void CheckExpirationContract(this Fruit fruit)
        {
            fruit.Expire();
            Assert.IsTrue(fruit.IsExpired);
        }
    }
}
