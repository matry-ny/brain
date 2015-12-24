using System;
using System.Runtime.Remoting.Channels;
using BrainConsoleApp.OOP.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.Events
{
    [TestClass]
    public class ToasterTests
    {
        private bool _isToasterRinged = false;

        private void HandleTosterRing(object sender, EventArgs args)
        {
            _isToasterRinged = true;
        }

        [TestMethod]
        public void BreadSliceIsToastedWellTest()
        {
            var timerFake = new ToasterTimerFake();
            var toaster = new Toaster(timerFake);

            var isToasterRinged = false;
            //toaster.Ring += (sender, args) => { isToasterRinged = true; };
            toaster.Ring -= HandleTosterRing;
            toaster.Ring += HandleTosterRing;

            var freshSlice = new BreadSlice();
            var toastedSlice = new BreadSlice {State = BreadSliceState.Toasted};
            var burnedSlice = new BreadSlice {State = BreadSliceState.Burned};
            var niggaSlice = new BreadSlice {State = BreadSliceState.Nigga};
            
            var slices = new[]
            {
                freshSlice, toastedSlice, burnedSlice, niggaSlice
            };

            // act
            toaster.Toast(slices, 0);
            timerFake.ReiseCompleteEvent();

            // assert
            Assert.IsTrue(_isToasterRinged);
            Assert.AreEqual(BreadSliceState.Toasted, freshSlice.State);
            Assert.AreEqual(BreadSliceState.Burned, toastedSlice.State);
            Assert.AreEqual(BreadSliceState.Nigga, burnedSlice.State);
            Assert.AreEqual(BreadSliceState.Nigga, niggaSlice.State);
        }
    }
}
