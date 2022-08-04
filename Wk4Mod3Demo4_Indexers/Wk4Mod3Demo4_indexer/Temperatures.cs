using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Mod3Demo4_indexer
{
  internal class TempRecords
    {


        float[] temps = new float[10]
        {
            45.4F, 45.7F, 23.4F, 45.1F, 27.4F, 84.4F, 99.4F, 21.4F, 83.5F, 82.0F
        };


        public int Length
        {
            get { return temps.Length; }
        }




        // This is an indexer declaration. We use the 'this' property. This will allow us to read or write at specific indexes of an array. 
        public float this[int index]
        {
            get { return temps[index]; }
            set { temps[index] = value; }       
        } 
    }
}
