using System;
using System.Runtime.Serialization;

namespace BrainConsoleApp.OOP.Exceptions
{
    [Serializable]
    public class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
        }

        public MyException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MyException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}