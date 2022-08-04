using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Mod3Demo4_indexer
{
    internal struct Menu
    {



        string[] beverages;

        public Menu(string[] beverages) 
        {
            this.beverages = beverages; 
          //  Array.Copy(beverages, this.beverages, beverages.Length);
          

           
        }

        public string this[int index]
        {
            get {  return beverages[index]; }
            set { beverages[index] = value; }
        }

    }
}
