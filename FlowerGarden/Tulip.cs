using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerGarden
{
    public class Tulip: Flower
    {
        public Tulip(double price) : base(price)
        {
            Name = "Тюльпан";
        }
    }
}
