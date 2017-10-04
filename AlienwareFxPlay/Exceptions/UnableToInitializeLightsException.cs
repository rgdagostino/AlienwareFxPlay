using System;
using System.Runtime.Serialization;

namespace AlienwareFxPlay.Exceptions
{
    [Serializable]
    public class UnableToInitializeLightsException : Exception
    {
      
        public UnableToInitializeLightsException(string message) : base(message)
        {
        }

        public UnableToInitializeLightsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected UnableToInitializeLightsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
