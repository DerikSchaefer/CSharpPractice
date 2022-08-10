using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates3
{
    internal class Program
    {
        // Delegate declaration. This can be done inside a class as well as inside the namespace directly 
        public delegate bool Filter(Person person);
        static bool isMinor(Person person)
        {
            if (person.Age < 18) return true;
            else return false;
        }

        static bool isSenior(Person person)
        {
            if (person.Age < 65) return true;
            else return false;
        }

        static void DisplayPerson(string title, List<Person> people, Filter filter)
        {
            Console.WriteLine(title);
            foreach(Person person in people)
            {
                if(filter(person))
                {
                    Console.WriteLine($"Person's name: {person.Name} , age: {person.Age}"); 
                }
            }
        }
        static void Main(string[] args)
        {

            List<Person> person = new List<Person>();

            person.Add(new Person() { Age = 12, Name = "Derik" });
            person.Add(new Person() { Age = 18, Name = "Joe" });
            person.Add(new Person() { Age = 72, Name = "Jim" });
            person.Add(new Person() { Age = 1, Name = "Kim" });
            person.Add(new Person() { Age = 35, Name = "Samantha" });


        }
    }
}
