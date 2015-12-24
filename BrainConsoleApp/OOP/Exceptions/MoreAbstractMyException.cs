using System;
using System.Runtime.Serialization;

namespace BrainConsoleApp.OOP.Exceptions
{
    [Serializable]
    public class MoreAbstractMyException : Exception
    {
        public MoreAbstractMyException()
        {
        }

        public MoreAbstractMyException(string message) : base(message)
        {
        }

        public MoreAbstractMyException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MoreAbstractMyException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}