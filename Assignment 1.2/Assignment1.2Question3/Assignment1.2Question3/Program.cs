using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2Question3
{
    internal class Program
    {

/* Write a C# Sharp program to find the sum of first 10 natural numbers.
Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55*/

        static void Sumof10()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;

                Console.Write("{0}", i);
            }

            Console.Write("\n The Sum is: {0}", sum);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {

            char choice = 'z';
            Console.WriteLine("Do you want to see the sum of the first 10 natural numbers?? Y/N");
            choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'y' || choice == 'Y')
            {
                Sumof10();
            }
        }
    }  
}
