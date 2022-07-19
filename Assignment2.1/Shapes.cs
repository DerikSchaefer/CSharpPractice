using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{

// Create abstract class for shapes

    abstract class Shapes
    {
// Add properties, id name color
        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }
        public string color
        {
            get;
            set;
        }

        public virtual double GetArea(double height, double length)
        {
            return height * length;
        }
    }
 // Create a subclass of shapes named circle
    class Circle : Shapes
    {

// Create a public member radius, get & set
        public double radius { get; set; }

 //Use override method to change the logic of this inherited method

        // change the parameters here to what I need to find the area of a circle
        public override double GetArea(double radius, double pi)
        {

            //instantiate the variables I'll be using 
            double area;
            area = (pi * radius * radius);

            // Write the result to the console

            Console.WriteLine($"The area of your circle is {area}");

            // ReadLine to pause the console

            Console.ReadLine();

            //Return otherwise 'Not all code paths return a value'
            return area;

        }


    }

}