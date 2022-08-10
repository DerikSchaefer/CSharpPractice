using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedinterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a generic, this is a dynamic list
            // of integers

            List<int> list = new List<int>();
            List<int> list1 = new List<int> { 5, 6, 7 };
            list.Add(9);
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            list.AddRange(list1);
            list.Sort();

          //  Console.WriteLine("Sorted list:");
          //  Console.WriteLine(list);
            Console.ReadLine();

            foreach (var i in list)
            {
               // Console.WriteLine(i);              
            }
            Console.ReadLine();

            List<string> names = new List<string> { "Z", "F", "Y" };
            names.Sort();
            foreach (var name in names)
            {
              //  Console.WriteLine(name);
            }
            Console.ReadLine();

            List<student> students = new List<student>();
            students.Add(new student() { ID = 1, Name = "Jim", Grade = 78.8, Age = 6 });
            students.Add(new student() { ID = 2, Name = "Joe", Grade = 77.8, Age = 5 });
            students.Add(new student() { ID = 3, Name = "John", Grade = 71.8, Age = 5 });
            students.Add(new student() { ID = 4, Name = "Jill", Grade = 58.8, Age = 4 });
            students.Add(new student() { ID = 5, Name = "Jen", Grade = 98.8, Age = 7 });
            students.Add(new student() { ID = 6, Name = "Jay", Grade = 88.8, Age = 6 });
            // students.Sort();

            students.Sort(new StudentGradeComparer());

            Console.WriteLine("Sorted list of students");
            foreach (var student in students)
            {
                Console.WriteLine($"Student id:{student.ID}, Student name: {student.Name}, Student grade: {student.Grade}, Student Age: {student.Age} ");
            }
            Console.ReadLine();
        }
    }
}
