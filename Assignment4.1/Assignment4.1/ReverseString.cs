using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal class ReverseString
    {

        string[] results = new string[1];

        public string reverseIt(string inputString)
        {

            string reversedString = "";
            int length = inputString.Length - 1;

            while (length >= 0)
            {
                reversedString = reversedString + inputString[length];
                length--;
            }
            Console.WriteLine($"Here is your reversed string: {reversedString}");
            Console.ReadLine();
            return reversedString;
        }
    }
}