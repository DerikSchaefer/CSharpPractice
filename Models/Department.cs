using System.ComponentModel.DataAnnotations;

namespace EmpManagementSystem.Models
{
    // master table
    public class Department
    {
        [Key] // primary key in table
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        // 1 to many relation
        public virtual ICollection<Employee>? Employees { get; set; }

    }
}
