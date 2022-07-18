using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo1
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //not allowed because the base class is 'abstract'
           // Person person = new Person();


            Instructor instructor1 = new Instructor();

            instructor1.FirstName = "Derik";
            instructor1.Eat(); // instance methods, these need an instance to invoke them because they are within an abstract class. 
            instructor1.Communication();
            instructor1.DoWork();
            Console.ReadLine();

            Console.WriteLine("Instructor2");
            Person instructor2 = new Instructor(); // cross refernece 
            instructor2.DoWork(); // derived class : override
            instructor2.Communication(); // considers base clsas functionality
            Console.ReadLine();

            Console.WriteLine("Student Info");
            Student student1 = new Student();
            student1.FirstName = "Derik";
            student1.DoWork();
            student1.FollowSchedule();
            Console.ReadLine();
          

        }
    }
}
