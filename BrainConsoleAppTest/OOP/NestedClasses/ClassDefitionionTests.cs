using System;
using BrainConsoleApp.OOP.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.NestedClasses
{
    [TestClass]
    public class ClassDefitionionTests
    {
        [TestMethod]
        public void BrakeIncapsulationTest()
        {
            string expected = "Test string";
            var owner = new ClassDefinition(expected);
            var morosovInterface = new ClassDefinition.NestedPublicMorozow(owner);

            var result = morosovInterface.GetOwnerHiddenValue();

            Assert.AreEqual(result, expected);
        }
    }
}
