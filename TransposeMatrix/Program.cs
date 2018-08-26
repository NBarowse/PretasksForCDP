using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransposeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = TryParseInt("Enter number of rows:");
            int columnsCount = TryParseInt("Enter number of columns:");
            int[,] matrix = new int[rowsCount, columnsCount];
            for(int i=0; i<rowsCount; i++)
            {
                Console.WriteLine("Enter row {0}", i+1);
                for(int j=0;j<columnsCount;j++)
                {
                    matrix[i,j] = TryParseInt("Enter value:");
                }
            }
            DrawMatrix("Initial Matrix", matrix);
            Console.ReadKey();
            int[,] newMatrix = new int[columnsCount, rowsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    newMatrix[j, i] = matrix[i,j];                   
                }
            }
            DrawMatrix("Transposed Matrix", newMatrix);
            Console.ReadKey();
        }

        private static void DrawMatrix(string title, int[,] matrix)
        {
            Console.WriteLine(title);
            for (int i = 0; i < matrix.GetUpperBound(0) - matrix.GetLowerBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) - matrix.GetLowerBound(1) + 1; j++)
                {                   
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
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
    }
}
