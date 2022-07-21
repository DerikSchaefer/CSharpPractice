using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Demo1_MemoryAllocation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            num1 = 100;
            num2 = 200;

            Swap(ref num1, ref num2); // Function call

            // This does not work and swap the actual values because just a copy was made
        /*    Console.WriteLine($"Swapped values are num1:{num1} & num2 {num2}");
            Console.ReadLine();
*/
   /*         add(num1, num2);
*/
            
/*
            Console.WriteLine($"Swapped values are num1:{num1} & num2 {num2}");
            Console.ReadLine();*/



            StructTest structTest = new StructTest();
            structTest.i = 1;
            TestStruct(structTest);
            Console.WriteLine($"value of i from struct: {structTest.i}");
            Console.ReadLine();


            // If you passed this as TestStruct(ref structTest) it as well as in the function it would work to
            //change the actual value



            ClassTest classTest = new ClassTest();
            classTest.i = 1;
            TestClass(classTest);
            Console.WriteLine($"value of i from class: {classTest.i}");
            Console.ReadLine();






        }



        // You would not need to use ref here because you're not trying to change the values of the 
        // variables passed as arguments, you're only trying to return the value of the operation.




        /*  static int add(int i, int j)
          {
              i = i * 2;
              return i - j;
          }
  */

        static void TestClass(ClassTest obj)
        {
            obj.i = 100;
        }
        
        static void TestStruct(StructTest obj)
        {
            obj.i = 100;
            Console.WriteLine($"Value of i {obj.i}");
        }
        
        
        static int Add(int i, int j)
        {
            return i + j;
        }

        static void Swap(ref int i, ref int j) // value types before the ref keyword was added. The ref
            //keyword points to the address of the actual variable now 
        {
            int temp;

            temp = i; 
            i = j; 
            j = temp;

        }




    }
}
