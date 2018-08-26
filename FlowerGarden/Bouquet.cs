using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerGarden
{
    public class Bouquet
    {
        private List<Flower> flowers = new List<Flower>();
        private double totalPrice;

        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
            totalPrice += flower.Price;
        }
        public double GetTotalPrice()
        {
            return totalPrice;
        }
    }
        
}
