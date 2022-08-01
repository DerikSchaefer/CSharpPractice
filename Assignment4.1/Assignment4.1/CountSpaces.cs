using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal class CountSpaces
    {

        public int countSpaces(string inputString)
        {

            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"Your string has {count} spaces in it");
            Console.ReadLine();
            return count;
        }
    }
}
