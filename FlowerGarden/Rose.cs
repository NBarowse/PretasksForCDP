using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerGarden
{
    public class Rose: Flower
    {
        public Rose(double price) : base( price)
        {
            Name = "Роза";
        }
    }
}
