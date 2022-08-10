using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedinterfaces
{

    interface I1
    {
        int Add(int i, int j);
    }

    interface I2
    {
        int Add(int i, int j, int k);

    }
    

    // no conflict here with the two methods with the same
    // name because the parameters are different. If the 
    // parameters were not different we would do explicit 
    // implementation instead


    class Test : I1, I2
    {
        public int Add(int i, int j, int k)
        {
          return i + j + k; 
        }

        public int Add(int i, int j)
        {
            return i + j;
        }
    }
}
