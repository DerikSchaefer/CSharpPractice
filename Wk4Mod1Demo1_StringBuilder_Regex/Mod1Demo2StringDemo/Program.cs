using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Mod1Demo2StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*
            // string concatenation: not efficient, creates this many strings. 
            string address;
            address = "27";
            address = address + " miller street";
            address = address + " NY";
            Console.WriteLine(address);
            Console.ReadLine();

            // String Builder is more efficient
            // Stringbuilder is a class included in the .net framework. We're creating an 
            // variable of this class (an object) and then using the .Append method and then passing
            // arguments to that method.
            StringBuilder newAddress = new StringBuilder();
            newAddress.Append("45");
            newAddress.Append(" lincoln blvd");
            newAddress.Append(" NJ");
            Console.WriteLine(newAddress.ToString());
            Console.ReadLine();

            string myAddress = newAddress.ToString();

            var reverse = myAddress.Reverse<char>();

            foreach (char c in reverse)
            {
                Console.Write(c);
                Console.ReadLine();

            }

*/

        


            int count = 0;
            /*  foreach (var c in newAddress.ToString()) 
              {
                  if (c == ' ')
                  {
                      count++;
                  }
                  Console.WriteLine(count);
                  Console.ReadLine();*/

            Console.WriteLine(CheckPhoneNumber("+23 578-045-888")); // true

            Console.WriteLine(CheckPhoneNumber("+444 578-045-888")); // false
            Console.WriteLine(CheckPhoneNumber("+00 578-045-888")); // false

            Console.ReadLine();


            Console.WriteLine("Please enter email id:");
                string emailtocheck = Console.ReadLine();
            if (CheckEmail(emailtocheck))
            {
                Console.WriteLine("Correct email");
            }
            else
            {
                Console.WriteLine("Error in email");
            }
        }


        static bool CheckPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^\+\d{2}\s(\d{3}\-){2}(\d{3})");
            Match match = regex.Match(phoneNumber);
            return match.Success;
        }


        static bool CheckEmail(string email)
        {
          string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var result = Regex.Match(email, emailpattern);
            return result.Success;
        }
    }
}



