using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Mod2Demo1_Methods
{
    internal class Program
    {

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        static void Main(string[] args)
        {
            int num1, num2, summ, product;
            num1 = 20;
            num2 = 30;
            summ = 0;
            product = 0;


            Operations(num1, num2);
            // we can capture the results of the method in another variable like this5
            int sum = Add(num1, num2);


            Console.WriteLine($"outside method {summ} {product}");
            Console.ReadLine();


            // We can call this method within another method like this
            Console.WriteLine(Add(num1, num2));


            // This is us invoking the function using integers as the arguments and then variables. 
            Add(3, 4);
            Add(num1, num2);

            // All these parameters would need to be filled in
            CalculateTax(45000, 10, "CA", 3);

          /*  StopService();*/
        }

        // this is an example to show how many different types of parameters we can have
        static double CalculateTax(double baseSalary, double contri, string state, int dependents)
        {
            // logic to calculate the tax
            return 0;
        }


        // This is an example of default & mandatory parameters. Mandatory parameters go to the left (first
        // and default/optional parameters go last. 
        static void StopService(string serviceName, int serviceId =1, int duration = 2) 
        {
            // logic goes here. 
        }

        static void Operations(int num1, int num2)
        {
            int summ, product;
            summ = num1 + num2;
            product = num1 * num2;

            Console.WriteLine($"Inside method {summ} {product}");
            Console.ReadLine();
        }

    }

}