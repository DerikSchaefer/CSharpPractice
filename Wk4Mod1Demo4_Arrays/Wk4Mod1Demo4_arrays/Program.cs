using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Mod1Demo4_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,,] 3d = new int[2,2,2]
            {
                { }
            }

            // 1 comma: 2d array, 2 commas: 3d array, no comma, single dimesnion array


            // row = student, columns = grades. each column can represent a different grade for a 
            // subject   // 5 is rows, 4 is columns. 

            Console.WriteLine("Enter number of students");
            int students = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of grades");
            int grades = Int32.Parse(Console.ReadLine());

            char[,] studentgrades = new char[students, grades]; // students * grades 
            Console.WriteLine("Enter grades for students:");


            // GetLength gives us the number of elements in the dimension we mentioned, 0 correlates to 
            // the 1st dimension which is 5, 1 is pointing to the second dimension which is 4


            for (int i = 0; i < grades.GetLength(0); i++)
            {
                Console.WriteLine("Enter grades for students:");
                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    Console.WriteLine($" Grade {j}");
                    grades[i, j] = Convert.ToChar(Console.ReadLine());
                }
            }
            Console.WriteLine("You entered following:");

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                Console.Write($"Student {i}");

                for (int j = 0; j < grades.GetLength(1); j++)

                {
                    Console.Write(" | {0} |" + "\t", grades[i, j]);
                }
                Console.ReadLine();
            }
        }
    }
}