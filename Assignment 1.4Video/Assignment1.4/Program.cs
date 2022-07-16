using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4
{
    internal class Program
    {

        //create a function to compare X and Y

        static void leftOrRight(int one, int two)
        {

            // declare the two variables inside the function

            Point point1 = new Point();
            Point point2 = new Point();

            //ask the user for input on what they want the values to be

            Console.WriteLine("Please enter the X cordinate followed by the Y cordinate for point 1\n");

            //readline method, int32 parse to convert it

            // assign that value to the variables

            point1.X = Int32.Parse(Console.ReadLine());
            point1.Y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the X cordinate followed by the Y cordinate for point 2\n");

            point2.X = Int32.Parse(Console.ReadLine());
            point2.Y = Int32.Parse(Console.ReadLine());

            //return both back to the user

            Console.WriteLine($"Point 1 has an X value of {point1.X} and a Y value of {point1.Y}\nPoint2 has an X value of {point2.X} and a Y value of {point2.Y}");

            // if else statement comparing point1 x to point2 x

            if (one < two)
            {
                // Return to the user if point2 is to the right of point 1
                Console.WriteLine("Point2 is to the right of Point1");
            }
            else
            {
                Console.WriteLine("Point2 is not to right of Point1");
            }
            //Console.Readline method to pause the console. 
            Console.ReadLine();
        }

        // create a function to instantiate a student class

        static void StudentDetails()
        {
            //instantiate a new student class with data
            Student newStudent = new Student(206, "Derik", "Schaefer", 'B');
            //return that to the user
            Console.WriteLine($"newStudent details are\nID: {newStudent.studentId}\n2. First Name: {newStudent.studentFName}\n3. Last Name: {newStudent.studentLName}\n4.Grade: {newStudent.studentGrade}");

            //readline to pause the console. 
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            Point point1 = new Point();
            Point point2 = new Point();

            Console.WriteLine("Do you want to check if one point is to the right of another on a cordinate grid or view student details?\n1. Coordinate Grid\n2.Student Details");

            int choiceOne = Int32.Parse(Console.ReadLine());

            switch (choiceOne)
            {
                case 1:
                    leftOrRight(point1.X, point2.X);
                    break;
                case 2:
                    StudentDetails();
                    break;
            }

        }
    }
}

//
//
//
//
//Instantiate the class and assign data to properties. Display the data back on console.