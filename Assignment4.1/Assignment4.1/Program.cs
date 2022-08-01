using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

    Console.WriteLine("Do you want to see all the even numbers between your number and zero, " +
    "check if a year is a leap year, reverse a string, or count the number of spaces in a string?" +
    "\n1.Even Numbers\n2.Leap Year\n" + "3.Reverse a string\n4.Count the spaces in a string");

    int choiceOne = Int32.Parse(Console.ReadLine());

            switch (choiceOne)
            {
                
                case 1:
                    Console.WriteLine("Please enter a number between 1 and 100");
                    int num = Int32.Parse(Console.ReadLine());
                    EvenNumbers numbers = new EvenNumbers();
                    numbers.ReturnEven(num);
                    break;
                
                case 2:
                    Console.WriteLine("Please enter a date in yyyy/mm/dd format:");
                    var year = Convert.ToDateTime(Console.ReadLine());
                    LeapYear leap = new LeapYear();
                    leap.IsLeap(year);
                    break;

                case 3:
                    Console.WriteLine("Please write the string to reverse");
                    string yourString = Console.ReadLine();
                    ReverseString reverseString = new ReverseString();  
                    reverseString.reverseIt(yourString);
                    break;

                case 4:
                    Console.WriteLine("Please write the string to count the spaces");
                    string inputString = Console.ReadLine();
                    CountSpaces countem = new CountSpaces();
                    countem.countSpaces(inputString);
                    break;
            }
        }
    }
}
