using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathdll
{


    // dll: dynamic linked library 
    public class MathCLs
    {

        public int Addd(int i, int j)
        {
            Helper helper = new Helper(); // we can use this
            return i + j;
        }


        // new function
        public int Multiplyy(int i, int j)
        {
            return i * j;
        }

    }


    // differences between .exe and dll
    // 1. exe has a main method, dll does not have a main method
    // 2. exe can run by itself, dll cannot run by itself. it must be used by something else
    // 3. dlls serve functionality. 
    // 4. exe : memory allocation, thread, process / .dll 


}
