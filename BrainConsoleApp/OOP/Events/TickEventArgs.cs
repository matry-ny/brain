using System;

namespace BrainConsoleApp.OOP.Events
{
    public class TickEventArgs : EventArgs
    {
        public TickEventArgs(int secondsSoFar)
        {
            SecondsSoFar = secondsSoFar;
        }

        public int SecondsSoFar { get; private set; }
    }
}