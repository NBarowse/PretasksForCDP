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
            Console.OutputEncoding = Encoding.UTF8;
            Bouquet bouquet = new Bouquet();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1 - Создать новый букет");
                Console.WriteLine("2 - Добавить цветок");
                Console.WriteLine("3 - Просмотреть букет");
                Console.WriteLine("4 - Рассчитать стоимость букета");
                Console.WriteLine("5 - Выход");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            BouquetManager.Create(bouquet);
                            break;
                        case 2:
                            BouquetManager.AddFlowerToBouquet(bouquet);
                            break;
                        case 3:
                            BouquetManager.Display(bouquet);
                            break;
                        case 4:
                            BouquetManager.DisplayPrice(bouquet);
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Неверный выбор");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (OutOfMemoryException error)
                {
                    Console.WriteLine("Возникла ошибка нехватки памяти для нового объекта: {0}", error.Message);
                    Console.ReadKey();
                }
                catch (IndexOutOfRangeException error)
                {
                    Console.WriteLine("Возникла ошибка выхода индекса массива за границу массива: {0}", error.Message);
                    Console.ReadKey();
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Возникла ошибка формата данных: {0}", error.Message);
                    Console.ReadKey();
                }
                catch (OverflowException error)
                {
                    Console.WriteLine("Возникло переполнение: {0}", error.Message);
                    Console.ReadKey();
                }                
                catch (Exception error)
                {
                    Console.WriteLine("Возникла ошибка: {0}", error.Message);
                    Console.ReadKey();
                }
            }             
           
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
