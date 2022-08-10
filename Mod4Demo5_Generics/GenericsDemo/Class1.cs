using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{

    // Generic class to do swapping of any data type
class Swap<T> // T: placeholder for the datatype 
    {

        // members 
        public void SwapData(ref T num1, ref T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;



        }
    }
}
