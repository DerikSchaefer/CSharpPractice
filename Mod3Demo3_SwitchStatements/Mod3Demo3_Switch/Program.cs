using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo3_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favColor = null;
            char choice = 'y';
            while (choice == 'y' ||choice == 'Y')
            {
                Console.WriteLine("Enter your favorite color");
                favColor = Console.ReadLine();
                

 
                Console.WriteLine("Enter your favorite color:");
               
                    
                

                switch (favColor.ToLower())
                {
                    case "Red":
                    case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Red it is!");
                    break;

                    case "Green":
                    case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Green it is!");
                    break;

                    default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Default Color");
                    break;
                }

                Console.WriteLine("Do you want to add another color? (enter y/Y for a yes)");
                choice = Convert.ToChar(Console.ReadLine());
               
            }
            Console.ResetColor();
            Console.ReadLine();
        }


       
        
    }
}
