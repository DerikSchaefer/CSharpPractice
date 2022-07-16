using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1._2Question1
{
    class Program
    {
        static void Addition()
        {
            Console.WriteLine("enter 2 numbers");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("result is " + result);

        }
        static void Subtraction()
        {
            Console.WriteLine("enter 2 numbers");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = num1 - num2;
            Console.WriteLine("result is " + result);

        }

        static void Multiplication()
        {
            Console.WriteLine("enter 2 numbers");
            float num1, num2;
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            float result = num1 * num2;
            Console.WriteLine("result is " + result);

        }

        static void Division()
        {
            Console.WriteLine("enter 2 numbers");
            float num1, num2;
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            float result = num1 / num2;
            Console.WriteLine("result is " + result);

        }
        static void Main(string[] args)
        {

            char choice = 'y';
            while (choice == 'y' || choice == 'Y')
            {
                CallMenu();
                Console.WriteLine("Do you want to continue?(enter y/Y for yes and N/n for no");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();

        }
        static void CallMenu()
        {
            Console.WriteLine("Which operation do you want to perform?\n 1. Addition\n 2. Subtraction\n 3. Multiplication\n 4. Division\n");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    break;

            }

        }
    }
}

