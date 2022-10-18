using Microsoft.EntityFrameworkCore;

namespace EmpManagementSystem.Models
{

    public class A
    {
        public A(int i)
        {

        }
    }
    public class B:A
    {
        public B(int i):base(i)
        {

        }

    }



    // class representing the db
    public class EmployeeContext:DbContext
    {
        // constructor
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }

        // emp table
        public DbSet<Employee>? Employees { get; set; }
        // dept table
        public DbSet<Department>? Departments { get; set; }

        // data seeding ( creating dummy records)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // adding dummy data in department
            modelBuilder.Entity<Department>().HasData(
                new Department { DeptId=1, DeptName="HR"},
                new Department { DeptId=2, DeptName="Finance"},
                new Department { DeptId=3, DeptName="IT"},
                new Department { DeptId=4,DeptName="Marketing"}
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id=101,Salary=3434,  Name="Sarah", DeptId=1, Department=Dept.HR, Age=33,ImageName="sarah.jpg",Address="NJ"},
                new Employee { Id =102, Salary=45445, Name = "Logan", DeptId = 2, Department = Dept.Finance, Age = 33, ImageName = "logan.jpg", Address = "NJ" }

                );



        }


    }
}
