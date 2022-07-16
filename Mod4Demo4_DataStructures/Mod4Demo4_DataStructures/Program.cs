using System;
using System.Collections.Generic; // improved namespace
using System.Collections; // previous namespace
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo4_DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array limitation : cannot dynamically grow

              
            // net 2.0 came out with ArrayList
          // This is an array that's size is dynamically increased as required. 
          ArrayList arrayList = new ArrayList(); // ref type

            arrayList.Add(3);
            arrayList.Add(4.5);
            arrayList.Add("Derik");
            //ArrayLists were not considered a good solution because they are not memory efficient. You are boxing and unboxing data
            //everytime. There are better collections that have come out since then
            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
            Stack stack = new Stack(3); // boxing and unboxing. 
            stack.Push(3); // Don't use stacks either

            List<int> list = new List<int>();  // When you see these angle brackets < > these are generics. These are the 'generics' 
            //which is what everyone is using nowadays. Don't use collections that don't have these angle brackets. 
            list.Add(3);    

            Console.ReadLine();
        }
    }
}
