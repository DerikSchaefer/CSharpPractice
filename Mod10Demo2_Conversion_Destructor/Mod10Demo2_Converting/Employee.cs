using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Demo2_Converting
{
    internal class Employee:IDisposable // IDosposable is an interface
    {

        public Employee()// constructor 
        {


        }

        //Freachable Q
        ~Employee() // destructor. Used for classes that use unmanaged resources (not managed in .net). 
            // example, MS Word. Also known as a finalizer
        {
            // reclaim the unmanaged resource, set to null

            // non deterministric 

        }

        public void Dispose ()
        {
            //Cleanup for unmanaged resources 
            // Deterministic approach 
        }

    }
}
