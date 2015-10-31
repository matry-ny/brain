using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class LiteralsTest
    {
        const int GREED_LIMIT = 2;

        [TestMethod]
        public void replaceTest()
        {
            var message = "Test string";
            message = message.Replace("string", "qwerty");
            Assert.AreEqual(message, "Test qwerty");
        }

        [TestMethod]
        public void slashesTest()
        {
            var message = "C:\\file.txt";
            Console.WriteLine(message);
            //Debug.WriteLine(message);

            var othetString = @"C:\files\test.txt";
            Assert.AreEqual("C:\\files\\test.txt", othetString);
            Console.WriteLine(othetString);
        }

        [TestMethod]
        public void constantsTest()
        {
            for (int step = 0; step <= GREED_LIMIT; step++)
            {
                Console.WriteLine("STEP #" + step + "\r\n");
            }
        }
    }
}
