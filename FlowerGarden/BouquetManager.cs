using System;

namespace FlowerGarden
{
    public class BouquetManager
    {
        public static void Create(Bouquet bouquet)
        {
            Console.WriteLine("Введите количество цветков в букете: ");
                bouquet.BouquetCount = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < bouquet.BouquetCount; i++)
                {
                    AddFlowerToBouquet(bouquet);
                }
                Console.WriteLine("Букет создан.");
                Console.ReadKey();                   
        }

        internal static void AddFlowerToBouquet(Bouquet bouquet)
        {
            Console.WriteLine("Выберете цветок:\n1 - Лилия\n2 - Роза\n3 - Тюльпан");
            int flowerNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену в руб: ");
            double flowerPrice = Double.Parse(Console.ReadLine());
            Flower flower = null;
            switch (flowerNumber)
            {
                case 1:
                    flower = new Lily(flowerPrice);
                    break;
                case 2:
                    flower = new Rose(flowerPrice);
                    break;
                case 3:
                    flower = new Tulip(flowerPrice);
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
            bouquet.AddFlower(flower);
            Console.WriteLine("Цветок добавлен в букет.");
            Console.ReadKey();
        }

        internal static void DisplayPrice(Bouquet bouquet)
        {
            Console.WriteLine("Цена букета составляет {0:0.00} руб.", bouquet.GetTotalPrice());
            Console.ReadKey();
        }

        internal static void Display(Bouquet bouquet)
        {
            Console.WriteLine("*************Букет из {0} цветка(-ов)*************", bouquet.BouquetCount);
            for (int i = 0; i < bouquet.BouquetCount; i++)
            {
                Console.WriteLine("{0} - {1}, {2} руб", i + 1, bouquet.flowers[i].Name, bouquet.flowers[i].Price);
            }
            Console.ReadKey();
        }
    }
}
