using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManagementSystem.Models
{
    //1. add model
    public enum Dept
    {
        HR=1,
        Finance,
        IT,
        Marketing
    }
    public class Employee
    {
        [Display(Name="Employee Id")]
        [Required(ErrorMessage ="Please fill in id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int DeptId { get; set; } //  foreign key

        [Display(Name="Employee Name")]
        [Required(ErrorMessage ="Please fill in name")]
        [MaxLength(10)]
        [AllLetters(ErrorMessage ="Please enter letters only!")]
        public string? Name { get; set; }

        [Range(18,80, ErrorMessage ="PLease fill age between 18 and 80")]
        public int Age { get; set; }

        [Display(Name="Home Adress")]
        [DataType(DataType.MultilineText)]
        [MaxLength (250, ErrorMessage ="Address too long")]
        public string? Address { get; set; }

        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        public Dept Department { get; set; }

        public string? ImageName { get; set; }



    }
}
