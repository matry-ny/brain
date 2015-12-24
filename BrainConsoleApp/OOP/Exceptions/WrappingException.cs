using System;
using System.Runtime.Serialization;

namespace BrainConsoleApp.OOP.Exceptions
{
    [Serializable]
    public class WrappingException : Exception
    {
        public WrappingException(Exception inner) : base("Loock inside", inner)
        {
        }
    }
}