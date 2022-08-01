using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal class EvenNumbers
    {
        public int ReturnEven(int numbers)
        {
            for (int i = -2; i < numbers; numbers--)
            {
                if (numbers % 2 == 0)
                {
                    Console.WriteLine(numbers);
                }
            }
            Console.ReadLine();
            return numbers;
        }
    }
}