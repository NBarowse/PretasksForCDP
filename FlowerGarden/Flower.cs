using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerGarden
{
    public abstract class Flower
    {
        public string Name { get; set; }
        public double Price { get; set; }
              
        public Flower(string name,  double price)
        {
            Name = name;    
            Price = price;
        }

    }
}
