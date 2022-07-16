using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Employee employee1 = new Employee();

            employee1 = new Employee();
            employee1.Eid = 101;
            employee1.Name = "k";
            employee1.FirstName = "deepali";
            employee1.HourlyRate = 26.7m;
            employee1.hours = 40.0m;
            decimal sal = employee1.CalculateSalry();
            Console.WriteLine($"salary is {sal}");
            Console.ReadLine(); 

        }
    }
}
