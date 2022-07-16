using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo1
{
    internal class Program
    {

        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2; 
        }

        static int Multiplication(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        static void Main(string[] args)
        {
            int num1 = 0; //initalization
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Please enter three numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            int product = Multiplication(num1, num2, num3);  // function call 
            int sum = AddNumbers(num1, num2);  // initalization as well but value is generated at runtime 
            Console.WriteLine("The sum of your two numbers is {0}", sum);
            Console.WriteLine("The product of your three numbers is {0}", product);
            Console.ReadLine(); //This is what returns the results of the function call back to us on the console
        /*    PrintName(); // calling a function
            PrintName();*/

        }

        // 1. Dont write a function in a function
        // 2. Always write a function in a class

        static void PrintName()   // No parameters here && function declaration. We give the return type, then the name
            // of the function, then in the brackets we give the parameters. 
        {
            // This is the function body, this is where the logic goes
   /*         string name; // declaring variable to store name 
            Console.WriteLine("Please enter your name"); // prompt user
            name = Console.ReadLine(); // get input from user
            string lname = "K";
            Console.WriteLine($"Hello {name} {lname}"); //print back
            Console.WriteLine($"Hello {0}", name);
            Console.ReadLine();*/
        }
    }
}
