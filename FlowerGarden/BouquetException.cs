using System;
using System.Runtime.Serialization;

namespace FlowerGarden
{
    [Serializable]
    internal class BouquetException : Exception
    {
        public BouquetException()
        {
        }

        public BouquetException(string message) : base(message)
        {
            Console.WriteLine("***BouquetException***");
        }

        public BouquetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BouquetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}