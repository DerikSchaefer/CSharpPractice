using Mod7EmpSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7SQLConnection
{
    interface CRUD
    {

        int GetMaxId();

        void AddRecord(Employee employees);
        void DeleteRecord(Employee employee);

        ICollection<Employee> GetAllRecords();

        Employee FindEmployee(int id);

        void UpdateRecord(int id, Employee employee);

        ICollection<DepartmentTable> GetAllDepartTable();


    }

    class EmpRepository : CRUD
    {

        // list. this will have a collection of departments and employees now 
        PCAD7EmployeesEntities entities;

        // Constructor
        public EmpRepository()
        {
            entities = new PCAD7EmployeesEntities();
            foreach (var e in entities.Employees)
            {
                foreach(var d in entities.DepartmentTables)
                {
                    if(e.DeptId == d.DeptId)
                    {
                        e.DeptName = d.DeptName;
                    }
                }
            }
        }

        public void AddRecord(Employee employee)
        {
            entities.Employees.Add(employee); // Add the employee object into that list
            entities.SaveChanges(); // updating the actual db from server
        }

        public void DeleteRecord(Employee employee)
        {
            entities.Employees.Remove(employee);
            entities.SaveChanges();
        }

        public Employee FindEmployee(int id)
        {
             return entities.Employees.Find(id);
        }

        public ICollection<DepartmentTable> GetAllDepartTable()
        {
            return entities.DepartmentTables.ToList();
        }

        public ICollection<Employee> GetAllRecords()
        {
            return entities.Employees.ToList();
        }

        public int GetMaxId()
        {

 
            return entities.Employees.Max(p => p.EmployeeId);
        }

        public void UpdateRecord(int id, Employee employee)
        {

            var emptoupdate = entities.Employees.Find(id); // ref of the emp
            emptoupdate.EmployeeId = employee.EmployeeId;
            emptoupdate.EmployeeName = employee.EmployeeName;
            emptoupdate.EmpSalary = employee.EmpSalary;
            emptoupdate.DeptId = employee.DeptId;
            entities.SaveChanges();

         
        }
    }
}