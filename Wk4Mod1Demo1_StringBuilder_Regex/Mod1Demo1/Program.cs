using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 23;  // explicity typed
            var num1 = 100;
            var name = "Deepali";
            var rate = 3.4f; // becomes float


            string[] myArray = { "apple", "banana", "grapes" };

            var result = from fruit in myArray
                         where fruit[0] == 'g'
                         select fruit;

            Console.WriteLine("Fruits starting with G");
            foreach (var fruit in myArray)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();



        }
    }
}
