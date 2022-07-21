using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Mod10Demo2_Converting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i; /// value type

            object obj = new object(); // ref type
            i = 0;
            obj = i; // boxing: value type into ref type does not need explicit conversion

            int j = (int)obj; // unboxing : ref to value, needs explicit conversion

            ArrayList list = new ArrayList(); // not a good thing to use 
            List<int> list2 = new List<int>(); // this is dynamic. Type sasfe list, no boxing / unboxing


            Employee emp = new Employee();
           emp = null; 
            emp.Dispose(); // when job is done we can call dispose method. 


            GC.Collect(); // we can force a garbage collection like this, there are also overloads available. 
        }
    }
}
