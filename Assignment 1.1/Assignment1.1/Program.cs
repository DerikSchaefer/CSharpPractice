using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            /*    Create a simple console application and store your name, age(should take decimal), address
            in a string variable and print them back on console. Prompt the user to each time enter
            name, age and address.*/

            string name;
            float age;
            string address;

            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age, you can use decimals");
            age = Single.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your address:");
            address = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Your name is {0}, your age is {1}, your address is {2}", name, age, address);
            Console.WriteLine("\n");
        8
            /*Create a simple console application and declare basic datatypes like int, float, decimal, double
            and print their min and max values.*/

            int testInt;
            float testFloat;
            decimal testDecimal;
            double testDouble;

            Console.WriteLine("The minimum value of an integer is {0}, the maximum value is {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("\n");
            Console.WriteLine("The minimum value of an float is {0}, the maximum value is {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("\n");
            Console.WriteLine("The minimum value of an decimal is {0}, the maximum value is {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("\n");
            Console.WriteLine("The minimum value of an double is {0}, the maximum value is {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
