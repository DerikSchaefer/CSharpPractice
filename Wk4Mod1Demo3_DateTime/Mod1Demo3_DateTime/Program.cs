using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Demo3_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your date of birth in yyyy/mm/dd format: ");
            var dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"You are {CalculateAge(dob)} years old");
            Console.ReadLine();
        }

        static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            int months = DateTime.Now.Month - dateOfBirth.Month;
            return age;
        }

        
    }
}
