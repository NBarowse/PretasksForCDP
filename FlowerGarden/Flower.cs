using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerGarden
{
    public abstract class Flower
    {
        double price;
        public double Price
        {
            get { return price; }

            set {
                if (value <= 0)
                    throw new FlowerException("Цена должна быть больше нуля.");
                else
                    price = value;

            }
        }
        public string  Name { get; set; }
        public Flower( double price)
        {  
            Price = price;
        }

    }
}
