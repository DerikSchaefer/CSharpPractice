using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Mod3_Demo3_Employee
{

    enum Department
    {
        IT,
        Finance,
        HR,
        Marketing
    };

    struct Employee
    {
        public int Eid { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }    

        public int Salary { get; set; } 

        public Department Dept { get; set; }
    }


    internal class EmployeeStruct
    {
    }
}
