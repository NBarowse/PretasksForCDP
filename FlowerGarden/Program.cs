using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet bouquet = new Bouquet();

            bouquet.AddFlower(new Tulip("Тюльпан", 1));
            bouquet.AddFlower(new Tulip("Тюльпан", 1.5));
            bouquet.AddFlower(new Rose("Роза", 2));
            bouquet.AddFlower(new Lily("Лилия", 3.5));          

           
            Console.WriteLine("Price of the bouqet is {0:0.00}", bouquet.GetTotalPrice());
            Console.ReadKey();
        }

       
       /* private static int TryParseInt(string text)
        {
            Console.WriteLine(text);
            string value = Console.ReadLine();
            int result;
            while (!Int32.TryParse(value, out result))
            {
                Console.WriteLine("Incorrect input !");
                Console.WriteLine(text);
                value = Console.ReadLine();
            }
            return result;
        }
        private static double TryParseDouble(string text)
        {
            Console.WriteLine(text);
            string value = Console.ReadLine();
            double result;
            while (!Double.TryParse(value, out result))
            {
                Console.WriteLine("Incorrect input !");
                Console.WriteLine(text);
                value = Console.ReadLine();
            }
            return result;
        }*/
    }
}
