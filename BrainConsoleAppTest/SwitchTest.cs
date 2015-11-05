using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class SwitchTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var key = ConsoleKey.Spacebar;

            switch (key)
            {
                case ConsoleKey.Spacebar:
                    Console.WriteLine("SpaceBar");
                    break;
                default:
                    Assert.Fail();
                    break;
            }
        }
    }
}
