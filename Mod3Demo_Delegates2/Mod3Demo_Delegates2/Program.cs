using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo_Delegates2
{
    internal class Program
    {

        static bool PromotableByGrade(Employee employee)
        {
            if (employee.Grade == 'A') return true;
            else return false;
        }

        static bool PromotedByExp(Employee emp)
        {
            if (emp.YearsExp > 5) return true;
            else return false;
        }



        static void Main(string[] args)
        {
            IsPromotable del1 = new IsPromotable(PromotedByExp);
            IsPromotable del2 = new IsPromotable(PromotableByGrade);
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Eid = 1, Name = "Kevin", YearsExp = 6, Grade = 'A' });
            list.Add(new Employee() { Eid = 2, Name = "Joe", YearsExp = 3, Grade = 'B' });
            list.Add(new Employee() { Eid = 3, Name = "Karen", YearsExp = 1, Grade = 'A' });
            list.Add(new Employee() { Eid = 4, Name = "Derik", YearsExp = 5, Grade = 'C' });
            list.Add(new Employee() { Eid = 5, Name = "Joshua", YearsExp = 7, Grade = 'B' });
            list.Add(new Employee() { Eid = 5, Name = "Nate", YearsExp = 2, Grade = 'C' });

            // this is following a predicate, this is a function delegate that is included in the class library 
       //     list.FindAll(x => x.YearsExp == 5); 



            foreach (var emp in list)
            {
         //       Console.WriteLine($"Employee name: {emp.Name} , emp id: {emp.Eid}");
                Console.WriteLine("Employees promoted by years of exp:");
                Employee.PromoteEmployee(list, del1);
                Employee.PromoteEmployee(list, del2);   
                Console.ReadLine();
            }
        }

    }
}
