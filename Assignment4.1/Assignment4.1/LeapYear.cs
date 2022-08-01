using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal class LeapYear
    {

        public bool IsLeap(DateTime date)
        {

            bool century;

            if (date.Year % 100 == 0)
            {
                century = true;
            }
            if (century = true && date.Year % 400 == 0)
            {
                Console.WriteLine("It is a leap year");
                Console.ReadLine();
                return true;
            }

            if (date.Year % 4 == 0)
            {
                Console.WriteLine("It is a leap year");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("That is not a leap year");
                Console.ReadLine();
                return false;
            }
        }
    }
}

