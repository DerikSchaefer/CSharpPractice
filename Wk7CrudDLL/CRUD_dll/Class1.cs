using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_dll
{


    internal class Student 
    {


    }

  interface CRUD
    {

        void AddRecord(Student student);
        void DeleteRecord(Student student);
        void UpdateRecord(int recordId, Student student);
        IEnumerable<Student> GetAll();


    }

    public class StudentRepository : CRUD
    {
        void CRUD.AddRecord(Student student)
        {
            throw new NotImplementedException();
        }

        void CRUD.DeleteRecord(Student student)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Student> CRUD.GetAll()
        {
            throw new NotImplementedException();
        }

        void CRUD.UpdateRecord(int recordId, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
