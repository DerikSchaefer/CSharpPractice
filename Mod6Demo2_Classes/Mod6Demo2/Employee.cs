using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Demo2
{

    // class: its a reference ty pe user defined complex data structure which can contain

    //data members, functions, events

    // OOPS: Object oriented programming uses classes and objects
    //Principles:
    //1. Abstraction: Filter out the properties and create a template  / blueprint. When we create a class we are often abstracting a real life enttity 
    //2. Encapsulation: hide data members, put together the properties and methods. 
    //3. Inheritance: inherit the properties / methods which are written in base class. 
    //4. Polymorphism: many forms. There may be a fnctionality in the base class but you would like to change it in the inherited class. You can do this, you can change this in the inherited/derrived class.

    internal class Employee
    {

        public int Eid
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public decimal HourlyRate
        {
            get;
            set;
        }
        public decimal hours
        {
            get;
            set;
        }

        public Employee()
        {

        }

        public Employee(int id, string name, string fname, decimal rate, decimal hours)
        {
            this.Eid = id;
            this.Name = name;
            this.FirstName = fname;
            this.HourlyRate = rate;
            this.hours = hours;

        }

        public decimal CalculateSalry()
        {
            return this.HourlyRate * this.hours;
        }
    }
}