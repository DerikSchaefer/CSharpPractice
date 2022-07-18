using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo1
{

    // base of class hierarchy, does not allow to create objects 

    //abstract: when I want to have a base template to put together behavior / characteristics but I don't want to instantiate it
    abstract class Person
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public float Height
        {
            get;
            set;
        }
        public float Weight
        {
            get;
            set;
        }

        //abstract method. You write these when you know that these methods will always change in the derrived class

        public abstract void FollowSchedule();

        //normal methods which is inherited as is
        public void Eat()
        {
            Console.WriteLine("I eat to live!");
        }

        //normal method 
        public void Communication()
        {
            Console.WriteLine("I use Engish to communicate");
        }

        // allows the developer to change the functionality if needed 
        public virtual void DoWork()
        {
            Console.WriteLine("I do some work!");
        }
    }

    //the : is how we denote inheritance. In this case we have access to the person class because we are in the same namespace as the person class

    // This instructor class is going to be a more specialized template. 
    class Instructor : Person
    {
        public int lectureHours
        {
            get;
            set;
        }
        public int labHours
        {
            get;
            set;
        }
        public decimal Salary
        {
            get;
            set;
        }

        //This type property, this is an example of different types of instructors but they're not so different that we need to make another class here
        // we can just do this as a property. Since all other properties are applicable to both we can just do it this way
        public string Type
        {
            get;
            set;
        } //part time / fill time

        public override void FollowSchedule()
        {
            Console.WriteLine("I work 10 to 6");
        }
        // Hiding the base class functionality because the base class function was not virtual. 
        public new void Communication()
        {
            //We can still call the base class functionality here if we want & add new functionality if we want. We don't have to though, if we
            // don't use this base keyword we would only have the new logic
            base.Communication();
            Console.WriteLine("I write in C#");
        }

        public override void DoWork()
        {

            //base is a keyword used to call immediate base class functionality
            base.DoWork();
            //add your own logic 
            Console.WriteLine("I also teach C#");
        }

        //It's easy to tell what you can override in C# because when you type the keyword override it will only show the properties you can override
    }

    // create a seperate class as part time if i have different set of properties to put in this class
    class PartTime : Instructor
    {
        //properties that are specific to just part time instructors. 
    }


}