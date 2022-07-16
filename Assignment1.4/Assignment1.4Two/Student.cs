using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4Two {

             //   2. Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) 
      //      and public properties for each data member.

    // this is going to be a class not a struct

  internal class Student {

    //create private int StudentId

    private int StudentId;

    //create private string StudentFname

    private string StudentFName;

    //create private string StudentLnane

    private string StudentLName;

    //create private char StudentGrade

    private char StudentGrade;

        //Now we're going to create our constructor. 

        //this will be public and have four parameters that correspond with the private data members

    public Student(int studentId, string studentFName, string studentLName, char studentGrade) {

   // again we're going to use the 'this' keyword to gain access to the private variables
      this.StudentId = studentId;
      this.StudentFName = studentFName;
      this.StudentLName = studentLName;
      this.StudentGrade = studentGrade;
    }

        //Now we will do our get / set statements for all four data members we created

    public int studentId {
      get {
 // for the get portion we're going to use the return keyword. Get is equivalent to read-only
    
//for the set portion we're going to use the value keyword. Set is equivalent to writing. Having both get & set makes this read/write.

        return StudentId;
      }
      set {
        StudentId = value;
      }
    }

    public string studentFName {
      get {
        return StudentFName;
      }
      set {
        StudentFName = value;
      }
    }

    public string studentLName {
      get {
        return StudentLName;
      }
      set {
        StudentLName = value;
      }
    }

    public char studentGrade {
      get {
        return StudentGrade;
      }
      set {
        studentGrade = value;
      }
    }
        //That's it
  }
}