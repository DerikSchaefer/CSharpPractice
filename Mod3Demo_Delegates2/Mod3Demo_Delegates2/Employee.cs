using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo_Delegates2
{

    // Delegate does not write the logic

    delegate bool IsPromotable(Employee emp);
    internal class Employee
    {

        public int Eid { get; set; }    
        public string Name { get; set; }    

        public int YearsExp { get; set; }   

        public char Grade { get; set; }

        public static void PromoteEmployee(List<Employee> elist, IsPromotable ispromo)
        {
            foreach (var employee in elist)
            {
                if (ispromo(employee))
                {
                    Console.WriteLine(employee.Name + " is promoted");
                }
            }
        }
    }
}
