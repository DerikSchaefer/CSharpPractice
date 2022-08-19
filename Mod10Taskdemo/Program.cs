using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Mod10Taskdemo
{
    internal class Program
    {
        // 1 thread
        static void Main(string[] args)
        {

            Task task1=new Task(LongrunningMethod);
            task1.Start();

            Task task2 = new Task(() =>
            {
                Console.WriteLine("Long running taks!");
            }

            );
            task2.Start();

            Task<decimal> task3 = Task.Run<decimal>(() =>
            {
                //logic
                return 3.4m;
            }

            );

            Task<string> task4 = Task.Run<string>(() =>

            {

            }
            );

            // start methods in parallel
            Parallel.Invoke(() => LongrunningMethod(),
                () => LongrunningMethod()

            );

            for(int i = 0; i < 10; i++)
            {

            }
            int start = 0, end = 99;
            int[] array = new int[100];
            Parallel.For(start, end, index =>
            {
                //logic 
                array[index] = index * index;
            });

            List<Student> students = new List<Student>() 
            { new Student { Id=1,Name="ABC"},
              new Student { Id=2,Name="XYz"}
            };

            // sequential LINQ
            var stud_with_A=from stud in students
                         where stud.Name.StartsWith("A")
                         //select stud;
                         select new {stud.Id , stud.Name }; // anonymous type
            foreach(var s in stud_with_A)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }
            // Parallel linq
            var student_with_A = from stud in students.AsParallel()
                                 where stud.Name.StartsWith("A")
                                 select stud;


            Console.ReadLine();




        }
        // simulation of long running method
        static void LongrunningMethod()
        {
            Thread.Sleep(1000);
            Console.WriteLine("LOng running method..");
        }
    }
}
