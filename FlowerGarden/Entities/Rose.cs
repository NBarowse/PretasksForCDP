using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlowerGarden
{
    [Serializable]
    public class Rose: Flower
    {
        public Rose()
        { }
        public Rose(double price) : base( price)
        {
            Name = "Роза";
            Code = 2;
        }
    }
}
