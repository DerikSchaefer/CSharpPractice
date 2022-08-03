using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._3
{
    enum MonthOfAdmission
    {
        January,
        Feburary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    };

    internal class Students
    {
        public int StudentId
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public char Grade
        {
            get;
            set;
        }
        public MonthOfAdmission monthOfAdmission
        {
            get;
            set;
        }

        struct Student { 
        
            
        
        
        
        }

    }
}