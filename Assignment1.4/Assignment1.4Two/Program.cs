using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4Two {

  internal class Program {

//static void name of the function and then the parameters we're expecting to pass

    static void leftOrRight(int one, int two) {

// we're going to declare our two variables point1 and point2 in here using the constructor we made before

       Point point1 = new Point();
      Point point2 = new Point();

    //We're going to ask the user for their input on what they want the values for x & y point 1 to be using the Console.WriteLine method

      Console.WriteLine("Please enter the X cordinate followed by the Y cordinate for point 1\n");

//Since this is going to return strings we're going to convert them to integers. We'll do that for both values


      point1.X = Int32.Parse(Console.ReadLine());
      point1.Y = Int32.Parse(Console.ReadLine());

//We'll do the same thing for point2

      Console.WriteLine("Please enter the X cordinate followed by the Y cordinate for point 2\n");

      point2.X = Int32.Parse(Console.ReadLine());
      point2.Y = Int32.Parse(Console.ReadLine());

//We'll do another Console.WriteLine method to just return to the user what they chose as the values

      Console.WriteLine($"Point1 has an X cordinate of {point1.X} and a Y cordinate of {point1.Y}\nPoint2 has an X cordinate of {point2.X} and a Y cordinate of {point2.Y}");

//Now we're going to make the actual logic of our function here which will be an if else statement comparing if parameter one (point1.x is larger than point2.x)
      
      if (one < two) {

          // if point 2 is larger than point 1 it will be to the right point 1 so we will return that
        Console.WriteLine("Point2 is to the right of Point1");
                // if it's not larger than we will return that it's not to the right
      } else {
        Console.WriteLine("Point2 is not to the right of Point1");
      }
      //We'll do a ReadLine() to pause our console so it doesn't close out on the user
      Console.ReadLine();
    }

//static void name() no parameters here I think because we're going to instantiate the class and declare all the properties inside the function

    static void StudentDetails() {

//We're going to create a new Student class using our constructor that we made in the student.cs file. 

           //I'll name it newStudent and I'll instantiate it with all the values filled in 

      Student newStudent = new Student(206, "Derik", "Schaefer", 'B');

            // I'll return all these student details to the user in the console
      Console.WriteLine($"newStudent details are: {newStudent.studentId}, {newStudent.studentFName}, {newStudent.studentLName}, {newStudent.studentGrade}");

            //Readline to pause the console
      Console.ReadLine();

    }

    static void Main(string[] args) {


                  //  Declare 2 points: P1 and P2.
  
      Point point1 = new Point();
      Point point2 = new Point();

            //Create a function for this which we will put outside our main method



  //  Determine if P2 is to the right or left of P1 
  //  or on same axis , by comparing the x xoordinates. ( if p1.x is more than p2.x , it is to the right )
 

 
         //   2. Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) 
      //      and public properties for each data member.
     

            //This part will be done here, everything else is going to be done in a seperate file so we will create that now



            // Now we're back to the main method

            //I'm going to create a function for this as well to keep it out of ouor main method as much as possible and also because I'm going to create a menu

      //      Instantiate the class and assign data to properties. Display the data back on console.






//Create a simple menu

            //Start with a WriteLine method asking which of the two options the uesr wants to do






      Console.WriteLine("Do you want to check if one point is to the right of another on a coordinate grid or view student details?\n1.Coordinates\n2.Student Details");

            //create a storage variable to store their choice, I'll get that choice back from a ReadLine method and convert it from a string to an int

      int choiceOne = Int32.Parse(Console.ReadLine());


// I'll create a short switch statement

      switch (choiceOne) {
                //If they choose 1 this will invoke the leftOrRight function I wrote earlier
      case 1:
        leftOrRight(point1.X, point2.X);
        break;
                    //If they choose 2 this will invoke the StudentDetails function I wrote earlier
      case 2:
        StudentDetails();
        break;
      }

            




    }
  }
}

