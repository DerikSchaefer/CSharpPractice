using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

/*Write a C# Sharp program to accept two integers and check whether they are equal or not.
Test Data:
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal

Test Data :
Input 1st number: 5
Input 2nd number: 15
Expected Output :
5 and 15 are not equal */


                static void CheckEqual()
            {
                Console.WriteLine("enter 2 numbers");
                int num1;
                int num2;
                num1 = Int32.Parse(Console.ReadLine());
                num2 = Int32.Parse(Console.ReadLine());

                if (num1 == num2)
                {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
                Console.ReadLine();
                }
                else if (num1 != num2)
                {
                Console.WriteLine("{0} and {1} are not equal", num1, num2);
                Console.ReadLine();
                }

            }

      

        static void Main(string[] args)
        {

            char choice = 'z';
                Console.WriteLine("Do you want to check if two numbers are equal? Y/N");
                    choice = Convert.ToChar(Console.ReadLine());
                        if (choice == 'y' || choice == 'Y')
                            {
                                CheckEqual();
                             }
        }
    }
}







