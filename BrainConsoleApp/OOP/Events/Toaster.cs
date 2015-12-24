using System;
using System.Linq;

namespace BrainConsoleApp.OOP.Events
{
    public class Toaster : IToaster
    {
        public event EventHandler<EventArgs> Ring;

        public event TickEventHeandler Tick;

        public readonly IToasterTimer _timer;

        private BreadSlice[] _slices;

        public Toaster(IToasterTimer timer)
        {
            _timer = timer;
        }

        public void Toast(BreadSlice[] slices, int seconds)
        {
            if (slices == null)
            {
                throw new ArgumentNullException("slices");
            }
            _slices = slices;
            _timer.Start(seconds);
            _timer.Complete += HandleTimerComplete;
        }

        private void HandleTimerComplete(object sender, TickEventArgs args)
        {
            _timer.Complete -= HandleTimerComplete;

            UpdateBreadStatus(_slices, args.SecondsSoFar);

            var handler = Ring;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private void UpdateBreadStatus(BreadSlice[] slices, int secondsSoFar)
        {
            if (secondsSoFar > 60)
            {
                foreach (var breadPart in slices)
                {
                    breadPart.State = BreadSliceState.Burned;
                }

                return;
            }

            foreach (var breadPart in slices)
            {
                var lastBreadState = Enum.GetValues(typeof(BreadSliceState)).Cast<BreadSliceState>().Max();
                if (breadPart.State < lastBreadState)
                {
                    breadPart.State++;
                }
            }
        }
    }
}
