using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace FlowerGarden
{
    public class BouquetManager
    {
        public static void Create(ref Bouquet bouquet)
        {
            if (bouquet.BouquetCount > 0) bouquet = new Bouquet();
            Console.WriteLine("Введите количество цветков в букете: ");
                bouquet.BouquetCount = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < bouquet.BouquetCount; i++)
                {
                    AddFlowerToBouquet(bouquet,false);
                }
                Console.WriteLine("Букет создан.");
                Console.ReadKey();                   
        }

        internal static void AddFlowerToBouquet(Bouquet bouquet, bool changeCount=true )
        {
            Console.WriteLine("Выберете цветок:\n1 - Лилия\n2 - Роза\n3 - Тюльпан");
            int flowerNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену в руб: ");
            double flowerPrice = Double.Parse(Console.ReadLine());
            Flower flower = FindFlower(flowerNumber, flowerPrice);
            bouquet.AddFlower(flower);
            if (changeCount==true) bouquet.BouquetCount++;
            Console.WriteLine("Цветок добавлен в букет.");
            Console.ReadKey();
        }

        private static Flower FindFlower(int flowerNumber, double flowerPrice)
        {
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

            return flower;
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
                
        internal static void DisplayPrice(Bouquet bouquet)
        {
            Console.WriteLine("Цена букета составляет {0:0.00} руб.", bouquet.GetTotalPrice());
            Console.ReadKey();
        }
        internal static void ReadFromTextFile(ref Bouquet bouquet)
        {
            if (bouquet.BouquetCount > 0) bouquet = new Bouquet();
            StreamReader fileIn = new StreamReader(@"C:\Users\Anastasiya_Maniak\source\repos\PretasksForCDP\BouquetFromTextFile.txt", Encoding.Default);
            string line;            
            while ((line = fileIn.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                Flower flower = FindFlower(Int32.Parse(parts[0]), Double.Parse(parts[2]));                
                bouquet.AddFlower(flower);
                bouquet.BouquetCount++;
            }
            fileIn.Close();
            Console.WriteLine("Букет прочитан из текстововго файла");
            Console.ReadKey();
        }

       
        internal static void WriteToTextFile(Bouquet bouquet)
        {
            StreamWriter fileOut = new StreamWriter(@"C:\Users\Anastasiya_Maniak\source\repos\PretasksForCDP\BouquetFromTextFile.txt", false);
            foreach (var flower in bouquet.flowers)
                fileOut.WriteLine("{0},{1},{2}", flower.Code,flower.Name,flower.Price);
            fileOut.Close();
            Console.WriteLine("Букет записан в текстовый файл");
            Console.ReadKey();
        }

        internal static void DeserializeFromBinFile(ref Bouquet bouquet)
        {
            if (bouquet.BouquetCount > 0) bouquet = new Bouquet();
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\Anastasiya_Maniak\source\repos\PretasksForCDP\BouquetFromBinFile.bin", FileMode.Open))
            {
                bouquet.flowers = (List<Flower>)bf.Deserialize(fs);
                bouquet.BouquetCount = bouquet.flowers.Count;
            }
            Console.WriteLine("Букет прочитан из бинарного файла");
            Console.ReadKey();
        }

        internal static void SerializeToBinFile(Bouquet bouquet)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\Anastasiya_Maniak\source\repos\PretasksForCDP\BouquetFromBinFile.bin", FileMode.Create))
            {
                bf.Serialize(fs, bouquet.flowers);
            }
            Console.WriteLine("Букет записан в бинарный файл");
            Console.ReadKey();
        }
        internal static void DeserializeFromXmlFile(ref Bouquet bouquet)
        {
            if (bouquet.BouquetCount > 0) bouquet = new Bouquet();
            XmlSerializer xs = new XmlSerializer(typeof(List<Flower>), new Type[] { typeof(List<Rose>), typeof(List<Tulip>), typeof(List<Lily>) });
            using (FileStream fs = new FileStream(@"C:\Users\Anastasiya_Maniak\source\repos\PretasksForCDP\BouquetFromXmlFile.xml", FileMode.Open))
            {
                bouquet.flowers = (List<Flower>)xs.Deserialize(fs);
                bouquet.BouquetCount = bouquet.flowers.Count;
            }
            Console.WriteLine("Букет прочитан из XML файла");
            Console.ReadKey();
        }

        internal static void SerializeToXmlFile(Bouquet bouquet)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Flower>), new Type[] { typeof(List<Rose>), typeof(List<Tulip>), typeof(List<Lily>) });
            using (FileStream fs = new FileStream(@"C:\Users\Anastasiya_Maniak\source\repos\PretasksForCDP\BouquetFromXmlFile.xml", FileMode.Create))
            {
                xs.Serialize(Console.Out, bouquet.flowers);
                xs.Serialize(fs, bouquet.flowers);
            }
            Console.WriteLine("\nБукет записан в XML файл");
            Console.ReadKey();
        }


    }
}
