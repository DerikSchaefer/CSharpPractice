using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo1_Interfaces
{
    public interface I1
    {

        // MVC: Model, View, Controller: loosely coupled 



        // can have method, properties, events inside interfaces. Cannot have instance fields. 

        // This variable does not work in here, not allowed
      //  int i;
        string Name { get; set; }    

        void Method1(int i);
    }
}
