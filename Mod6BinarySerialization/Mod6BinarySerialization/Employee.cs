﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6BinarySerialization
{
    [Serializable]
    internal class Employee
    {


        public int Eid { get; set; } 

        public string EName { get; set; }
        public double Salary { get; set; } 
    }
}
