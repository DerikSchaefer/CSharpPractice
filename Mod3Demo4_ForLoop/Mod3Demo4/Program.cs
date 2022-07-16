using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0; 
            for (int i = 0; i <= 5; i++)
            {
              Console.WriteLine("Please enter a number");
              int number =  Int32.Parse(Console.ReadLine());
              sum += number;  
            }
            Console.WriteLine($"The sum of the first 5 natural numbers is {sum}");
            Console.ReadLine();
            // This loop will take in 5 numbers from a user and add them together and return the sum
        }
    }
}
