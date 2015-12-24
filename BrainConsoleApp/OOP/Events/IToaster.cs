using System;

namespace BrainConsoleApp.OOP.Events
{
    public interface IToaster
    {
        event EventHandler<EventArgs> Ring;

        void Toast(BreadSlice[] slices, int seconds);
    }
}