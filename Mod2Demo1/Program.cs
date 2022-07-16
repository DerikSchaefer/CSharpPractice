using System; // highest level namesapce. Given to us by framework class library
using System.Collections.Generic;
using System.Linq;
// ^ These are sub namespaces. These are the commonly used ones but there are
//many more
using System.Text;
using System.Threading.Tasks;
//Namespace: A logical collection of classes which may or may not be related to each other. 
namespace Mod2Demo1 // user defined namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //namespace.class.method

            //Console is a system class which is why it's going to default to 
            //the system namesapce when you don't specify it with the full path

            System.Console.WriteLine("Welcome");
            Console.WriteLine("Hello");

            //These are both the same, the System.ConsoleWriteline is just the
            //full path

            int age;
            string name;
            decimal price;
            char c = 'Y';
            bool flag = true;

            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age in whole number:");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + name + "! You are {0} yeras old", age);
            Console.WriteLine("Max value in decimal is {0}", decimal.MaxValue);
            // 79228162514264337593543950335 is the max value, this is the long form version of 
          //  ±1.0 x 10 - 28 to ±7.9228 x 1028
            Console.ReadLine();
        
            // ^ this is called string interpolation


            //Int32 is a structure // template. This is done for readability. This shows that we're using
            //a method from the int structure. When declaring a variable you can just use int but when doing 
            //something like this you use Int32

            //We got an error here that says "Cannot implicity convert string to int". This means a 
            //conversion is needed
         

        }
    }
}
