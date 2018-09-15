using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.1	Цветочница. Определить иерархию цветов. Создать несколько объектов-цветов. Собрать букет с определением его стоимости. 
//3.1   Создать минимум 3 пользовательских исключения и использовать минимум 5 встроенных исключений.
//3.2   Дополнить сценарии, реализованные в задании 2.1 – добавить чтение и запись данных из следующих источников:
//      1.	из текстового файла
//      2.	из бинарного файла(используя сериализацию и десериализацию)
//4.1   Use the scenarios created in scope of the task 2.1, 3.1, 3.2. Add data reading from XML File using de\serialization


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
                Console.WriteLine("\n******TXT******");
                Console.WriteLine("5 - Прочитать букет из текстового файла");
                Console.WriteLine("6 - Записать букет в текстовый файл");
                Console.WriteLine("\n******BIN******");
                Console.WriteLine("7 - Прочитать букет из бинарного файла");
                Console.WriteLine("8 - Записать букет в бинарный файл");
                Console.WriteLine("\n******XML******");
                Console.WriteLine("9 - Прочитать букет из XML файла");
                Console.WriteLine("10 - Записать букет в XML файл");
                Console.WriteLine("\n11 - Выход");

                Console.Write("\nВаш выбор: ");
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
                            BouquetManager.ReadFromTextFile(ref bouquet);
                            break;
                        case 6:
                            BouquetManager.WriteToTextFile(bouquet);
                            break;
                        case 7:
                            BouquetManager.DeserializeFromBinFile(bouquet);
                            break;
                        case 8:
                            BouquetManager.SerializeToBinFile(bouquet);
                            break;
                        case 9:
                            BouquetManager.DeserializeFromXmlFile(bouquet);
                            break;
                        case 10:
                            BouquetManager.SerializeToXmlFile(bouquet);
                            break;
                        case 11:
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
                    Console.WriteLine("Возникла ошибка: {0}", error.InnerException);
                    Console.ReadKey();
                }
            }             
           
        }    
        
    }
}
