using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo2_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args) // Entry point. Everything in this main method will execute. This is where you
            //call functions from. 
        {
            Console.WriteLine("Enter the number of elements you want in the Fibonacci series");
            int fibLength = Int32.Parse(Console.ReadLine());    
            Fibonacci(fibLength);   // Call to function. 
            Console.ReadLine(); 
        }

        static void Fibonacci(int len)
        {
            int a = 0, b = 1, temp;
            Console.Write("{0} {1}", a, b);
            int i = len - 2;
            while (i > 0)
            {
                temp = a + b;
                Console.Write(" {0}", temp);
                a = b;
                b = temp;
                i--;
            }
        }

    }
}
