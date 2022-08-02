using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WkkMod1Demo4JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] citytemp = new int[5, 10];

            citytemp[0, 0] = 40;
            citytemp[0, 1] = 46;
            citytemp[0, 2] = 55;
            citytemp[0, 3] = 60;


            citytemp[1, 0] = 30;
            citytemp[1, 1] = 66;
            citytemp[1, 2] = 75;

            citytemp[2, 0] = 40;
            citytemp[2, 1] = 46;
            citytemp[2, 2] = 55;
            citytemp[2, 3] = 60;

            citytemp[3, 0] = 40;
            citytemp[3, 1] = 46;
            citytemp[3, 2] = 55;
            citytemp[3, 3] = 40;
            citytemp[3, 4] = 46;
            citytemp[3, 5] = 55;

            citytemp[4, 0] = 46;
            citytemp[4, 1] = 46;
            citytemp[4, 2] = 55;

            for (int i = 0; i < citytemp.GetLength(0); i++)
            {
                Console.Write($"City ({i}): ");

            for (int j = 0; j < citytemp.GetLength(1); j++)
                {
                  Console.Write(" |{0} F|" + " ", citytemp[i, j]);   
                }
               Console.WriteLine();
            }
            Console.ReadLine();



            // Jagged array: (ragged). This only 

            int[][] tempcities = new int[4][]; // array of arrays
            for (int i = 0; i < tempcities.Length; i++)
            {
                Console.WriteLine($"Enter how many readings received for city{i}");
                int readings = Int32.Parse(Console.ReadLine());
                tempcities[i] = new int[readings];
                Console.WriteLine($"Enter {readings} temperatures:");
                for(int j = 0; j < tempcities[i].Length; j++)
                {
                    tempcities[i][j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Temperatures are:");
            for (int i = 0; i < tempcities.Length; i++)
            {
                Console.Write($"City {i}:");
                for (int j = 0; j < tempcities[i].Length; j++)
                {
                    Console.Write(tempcities[i][j] + "F ");
                }
                Console.ReadLine();
            }
        }
    }
}
