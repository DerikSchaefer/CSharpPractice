using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Operations:");
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] sumArray = new int[array1.GetLength(0), array1.GetLength(1)];

            //filling in array1
            Console.WriteLine("Enter array1 elements:");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write($"Element |{i}| & |{j}|");
                    array1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            // filling in array2
            Console.WriteLine("Enter array2 elements:");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write($"Element |{i}| & |{j}|");
                    array2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            // display logic for array 1
            Console.WriteLine("You entered following for array1:");

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write($"|{array1[i, j]}| \t");
                }
                Console.WriteLine();
            }

            // display logic for array 2
            Console.WriteLine("You entered following for array2:");

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write($"|{array2[i, j]}| \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // adding the two arrays together
            Console.WriteLine("Sum of array1 and array2");

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    sumArray[i, j] = array1[i, j] + array2[i, j];
                    Console.Write($"|{sumArray[i, j]}| \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}