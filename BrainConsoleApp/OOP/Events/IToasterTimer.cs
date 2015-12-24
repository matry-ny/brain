namespace BrainConsoleApp.OOP.Events
{
    public interface IToasterTimer
    {
        event TickEventHeandler Complete;

        void Start(int interval);
    }
}