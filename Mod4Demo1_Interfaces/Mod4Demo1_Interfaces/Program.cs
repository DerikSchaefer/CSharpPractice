using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo1_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Advantages of interfaces:

            // It is used to achieve loose coupling
            // It is used for total abstraction 
            // Achieve multiple inheritance 
            // Add plug and play architecture 
            // United Testing 

            // Differences between abstract classes & interfaces. 
            // Abstract classes can contain normal methods (methods with logic) Intefaces do not. 
            // Abstract classes can have instance fields like variables, interfaces do not. 
            // Abstract classes do not allow multiple inheritance, interfaces allow it
        }

        interface I2
        {

            string Name
            {
                get;
                set;
            }

            void Method1(int i);
        }

        public class TestClass : I1, I2
        {
            public string Name
            {
                get =>
                  throw new NotImplementedException();
                set =>
                  throw new NotImplementedException();
            }

            public void Method1(int i)
            {
                //logic 
                throw new NotImplementedException();
            }

            public void Method2(int i)
            {
                throw new NotImplementedException();
            }
        }
    }
}