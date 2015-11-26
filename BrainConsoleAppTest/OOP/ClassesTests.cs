using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP
{
    public class Test
    {
        public static string qwerty = "YTRU";
    }

    [TestClass]
    public class ClassesTests
    {
        private readonly int amount = 10;

        public int Data { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            Data = 123;
            Console.Write(Data);
            Console.Write(Test.qwerty);
            Console.Write(amount);
        }
    }
}
