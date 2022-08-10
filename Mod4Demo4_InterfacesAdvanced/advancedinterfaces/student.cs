using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedinterfaces
{

    class StudentGradeComparer : IComparer<student>
    {
        public int Compare(student y, student x)
        {
            return (y.Age.CompareTo(x.Age));
        }
    }




    internal class student : IComparable<student>
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Grade { get; set; }

        public int CompareTo(student other)
        {
            return String.Compare(this.Name, other.Name);
        }
    }
}
