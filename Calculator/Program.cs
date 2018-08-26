using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double x = TryParseDouble("Enter the first number:");
                double y = TryParseDouble("Enter the second number:");
                int choice = TryParseInt("Select operation:\n1 - sum\n2 - subtraction\n3 - multiplication\n4 - division");                               
                double result = 0;
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        result = x + y;
                        Console.WriteLine("{0} + {1} = {2:0.00}", x, y, result);
                        break;
                    case 2:
                        result = x - y;
                        Console.WriteLine("{0} - {1} = {2:0.00}", x, y, result);
                        break;
                    case 3:
                        result = x * y;
                        Console.WriteLine("{0} * {1} = {2:0.00}", x, y, result);
                        break;
                    case 4:
                        result = x / y;
                        Console.WriteLine("{0} / {1} = {2:0.00}", x, y, result);
                        break;
                    default:
                        Console.WriteLine("Incorrect choice!");
                        break;
                }
                Console.WriteLine("Enter 1 to exit otherwise enter any other character");
                string exit = Console.ReadLine();
                if (exit=="1")
                    Environment.Exit(0);
            }
        }

        private static int TryParseInt(string text)
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
        }

    }
}
