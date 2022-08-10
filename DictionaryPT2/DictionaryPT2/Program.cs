using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPT2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, string> Recipies = new Dictionary<string, string>();
            Recipies.Add("Fried Rice", "quick fried rice");
            Recipies.Add("Stir Fry", "Make a stir-fry!");

            foreach (var name in Recipies)
            {
                Console.WriteLine(name);
            }
            
           Console.WriteLine("Enter the recipie to search:");
            string rec_name = Console.ReadLine();
            if(Recipies.ContainsKey(rec_name))
            {
                Console.WriteLine(Recipies[rec_name]);
            }
            Console.ReadLine();
           

        }
    }
}
