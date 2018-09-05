using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlowerGarden
{
    [Serializable]
    public class Tulip: Flower
    {
        public Tulip()
        { }
        public Tulip(double price) : base(price)
        {
            Name = "Тюльпан";
            Code = 3;
        }
    }
}
