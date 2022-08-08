using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDel del = new MyDel(Sayhello);
            del("all"); // calling the function through the delegate
            MyDel myDel = new MyDel(SayHi);
            Greetings(del);
            Greetings(myDel);
        }
            public static void Sayhello(string s)
            {
                Console.WriteLine("Hello " + s);
            }

        public static void SayHi(string a)
        {
            // logic
            Console.WriteLine("Hi " + a);
        }

        static void Greetings(MyDel my)
        {
            my("all");
        }
        }
    }

