using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignent4._4
{
    internal class Beverages
    {

        public abstract class Beverage
        {

            public string Regular { get; set; }  
            public string Large { get; set; }   

        }

        public class Coffee : Beverage
        {

            public string Name { get; set; }
    
        }



    }
}
