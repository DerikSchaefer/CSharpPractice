using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate new instance of this object
            Circle newCircle = new Circle();

            // Sollicit for an input from the user
            Console.WriteLine("Enter the radius of the circle you want to calcualte the area for");

            // We need a place to store this value, it will be a double data type so it has to be converted

            double radius = Convert.ToDouble(Console.ReadLine());

            // create our PI variable
            double pi = Math.PI;

            //Invoke the function 
            newCircle.GetArea(radius, pi);

            

        }

    }
}