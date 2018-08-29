using System;
using System.Runtime.Serialization;

namespace FlowerGarden
{
    [Serializable]
    internal class FlowerException : Exception
    {
        public FlowerException()
        {
        }

        public FlowerException(string message) : base(message)
        {
            Console.WriteLine("***FlowerException***");
        }

        public FlowerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FlowerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}