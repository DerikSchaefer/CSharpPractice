using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExentensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "test000";
            s.ContainsNumbers(); // useability
            s.Contains("test");
            ContainsNumbers(s);
            Console.WriteLine(s); 
        }

        public static bool ContainsNumbers(string s) // extending string functionality
        {
            return Regex.IsMatch(s, @"\d");
        }
    }
}
