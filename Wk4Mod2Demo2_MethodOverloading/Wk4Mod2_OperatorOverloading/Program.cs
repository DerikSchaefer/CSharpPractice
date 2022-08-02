using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Mod2_OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // the + operator is overloaded, it can either concatenate strings or add numbers
            int num = 5 + 6 + 8 + 9;

            string name = "welcome" + " all";

            circle c1 = new circle();
            c1.Radius = 23;
            circle c2 = new circle();
            c2.Radius = 34;
            var c3 = c1 + c2;
            c3.CalculateArea();
            Console.WriteLine($"Area of third circle is {c3.area}, the radius is {c3.Radius}");
            Console.ReadLine();


        }
    }
}
