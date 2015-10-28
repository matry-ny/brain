using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainConsoleApp;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class MessagesTest
    {
        [TestMethod]
        public void testGetHelloMessage()
        {
            var messagesClass = new Messages();
            string helloMessage = messagesClass.getHelloMessage();

            Assert.IsNotNull(helloMessage);
        }
    }
}
