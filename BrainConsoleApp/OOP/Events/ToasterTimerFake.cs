namespace BrainConsoleApp.OOP.Events
{
    public class ToasterTimerFake : IToasterTimer
    {
        public event TickEventHeandler Complete;
        public void Start(int interval)
        {
            Interval = interval;
        }

        public int Interval { get; private set; }

        public virtual void ReiseCompleteEvent()
        {
            var args = new TickEventArgs(Interval);

            var handler = Complete;
            if (handler != null)
            {
                handler(this, args);
            }
        }
    }

    public delegate void TickEventHeandler(object sender, TickEventArgs args);
}