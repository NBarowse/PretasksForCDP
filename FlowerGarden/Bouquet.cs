using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerGarden
{
    public class Bouquet
    {
        public List<Flower> flowers = new List<Flower>();
        private double totalPrice;
        double bouquetCount;
        public double BouquetCount
        {
            get { return bouquetCount; }

            set
            {
                if (value <= 0)
                    throw new BouquetException("Количество цветов в букете должно быть больше нуля.");
                else if( value >1000)
                    throw new BouquetException("Количество цветов в букете не может превышать 1000 штук.");
                else
                    bouquetCount = value;
            }
        }
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
