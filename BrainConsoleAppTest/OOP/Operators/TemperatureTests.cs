using System;
using BrainConsoleApp.OOP.Operators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.Operators
{
    [TestClass]
    public class TemperatureTests
    {
        [TestMethod]
        public void AdditionTest()
        {
            var delta = 17;
            var initialTemperature = new Temperature
            {
                Value = 23,
                Units = Units.Celsius
            };
            
            var expectedTemperature = new Temperature
            {
                Value = initialTemperature.Value + delta,
                Units = initialTemperature.Units
            };

            var result = initialTemperature + delta;

            Assert.AreEqual(result, expectedTemperature);
        }
        
        [TestMethod]
        public void If100CelsiusAbove100KelvinTest()
        {
            var a = new Temperature
            {
                Value = 100,
                Units = Units.Celsius
            };

            var b = new Temperature
            {
                Value = 100,
                Units = Units.Kelvin
            };

            var result = a > b;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If100KelvinIsBelowe100CelsiusTest()
        {
            var a = new Temperature
            {
                Value = 100,
                Units = Units.Celsius
            };

            var b = new Temperature
            {
                Value = 100,
                Units = Units.Kelvin
            };

            var result = a < b;

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            var initialTemperature = new Temperature
            {
                Value = 100,
                Units = Units.Kelvin
            };

            var result = initialTemperature - 22;
            Assert.AreEqual(result.Value, 78);

            result -= 8;
            Assert.AreEqual(result.Value, 70);
            Assert.AreEqual(result.Units, initialTemperature.Units);
        }

        [TestMethod]
        public void ImplicitStringCastTest()
        {
            var t = new Temperature()
            {
                Units = Units.Kelvin,
                Value = 123
            };

            string stringT = t;
            Assert.AreEqual(stringT, t.ToString());
        }
        
        [TestMethod]
        public void ExplicitStringCastTest()
        {
            var t = new Temperature()
            {
                Units = Units.Kelvin,
                Value = 123
            };

            int intT = (int)t;
            Assert.AreEqual(intT, t.ToCelsius().Value);
        }
    }
}
