using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.Events
{
    [TestClass]
    public class EventTests
    {
        private event EventHandler<EventArgs> Event; 

        [TestMethod]
        public void EventWithoutSubscribtionsIsNull()
        {
            Assert.IsNull(Event);
        }
    }
}
