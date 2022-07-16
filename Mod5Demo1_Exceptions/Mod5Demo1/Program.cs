using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        input: int num1,
        num2;
            Console.WriteLine("Please enter 2 whole numbers");
            bool flag1 = Int32.TryParse(Console.ReadLine(), out num1);
            bool flag2 = Int32.TryParse(Console.ReadLine(), out num2);
            int result;
            try
            {
                if (flag1 == true && flag2 == true)
                {
                    result = (num1 / num2);

                    Console.WriteLine($"Result is {result}");
                }
                else
                {
                    Console.WriteLine("Please enter valid numbers");
                    goto input;
                }

            }
            catch (ArithmeticException ex) // more specific 
            {
                //handle error/ exception
                Console.Write(ex.Message);
                goto input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto input;
            }
            finally
            {
                // mandatory code, file closing, db connection closing. 

            }
            Console.ReadLine();

        }
    }
}