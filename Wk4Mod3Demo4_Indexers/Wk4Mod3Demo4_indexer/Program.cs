using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Mod3Demo4_indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var temp = new TempRecords();

   


         

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
            Console.ReadLine();

            

            string[] beverages = new string[] { "Tea", "Soda" };

            Menu menu = new Menu(beverages);

            for (int i = 0; i < beverages.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
            Console.ReadLine();
    /*        foreach (var value in temp)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();

*/

        }
    }
}
