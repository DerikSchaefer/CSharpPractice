using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4
{

    //2.Write a class: “Student” with private data members: StudentId(int), StudentFname(string), StudentLname(string), StudentGrade(char) and public properties for
    //each data member.
    internal class Student
    {
        //Create private member variables for all the requested data

        private int StudentId;
        private string StudentFName;
        private string StudentLName;
        private char StudentGrade;

        public Student(int studentId, string studentFName, string studentLName, char studentGrade)
        {
            this.StudentId = studentId;
            this.StudentFName = studentFName;
            this.StudentLName = studentLName;
            this.StudentGrade = studentGrade;
        }

        public int studentId
        {
            get
            {
                return StudentId;
            }
            set
            {
                StudentId = value;
            }
        }

        public string studentFName
        {
            get
            {
                return StudentFName;
            }
            set
            {
                StudentFName = value;
            }
        }

        public string studentLName
        {
            get
            {
                return StudentLName;
            }
            set
            {
                StudentLName = value;
            }
        }

        public char studentGrade
        {
            get
            {
                return StudentGrade;
            }
            set
            {
                StudentGrade = value;
            }
        }

        //Create a constructor with four parameters to gain access to the private member variables

        //Create get and set statements x4

    }
}