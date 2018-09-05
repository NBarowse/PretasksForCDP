using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerGarden
{
    [Serializable]
    public class Lily: Flower
    {
        public Lily()
        { }
        public Lily( double price):base(price)
        {
            Name = "Лилия";
            Code = 1;
              
        }
    }
}
