using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment5._3
{
    public partial class StudentForm : Form
    {

        List<Student> students;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // load dummy data

            students = new List<Student>();

            students.Add(new Student()
            {
                Name = "Derik",
                Id = 1,
                GPA = 4.8F
            });
            students.Add(new Student()
            {
                Name = "Joe",
                Id = 2,
                GPA = 3.4F
            });
            students.Add(new Student()
            {
                Name = "Susan",
                Id = 3,
                GPA = 5.0F
            });
            students.Add(new Student()
            {
                Name = "Billy",
                Id = 4,
                GPA = 4.0F
            });
            students.Add(new Student()
            {
                Name = "Karen",
                Id = 5,
                GPA = 4.5F
            });
            students.Add(new Student()
            {
                Name = "John",
                Id = 6,
                GPA = 3.7F
            });
            students.Add(new Student()
            {
                Name = "Travis",
                Id = 7,
                GPA = 4.8F
            });
            students.Add(new Student()
            {
                Name = "Peter",
                Id = 8,
                GPA = 2.5F
            });
            students.Add(new Student()
            {
                Name = "Jennifer",
                Id = 9,
                GPA = 4.8F
            });
            StudentGrid.DataSource = students;
        }
        private void buttonGPA_Click(object sender, EventArgs e)
        {
            var highestGPA = students.Max(x => x.GPA);
            foreach (var student in students)
            {
                if (student.GPA == highestGPA)
                {
                    File.WriteAllText("C:\\Files\\StudentInfo.Text", $"Student name: {student.Name} Student GPA: {student.GPA} Student ID: {student.Id}");
                }
            }
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            if (TextName.Text != String.Empty || Int32.Parse(TextID.Text) != 0 || float.Parse(TextGPA.Text) != 0)
            {
                Student newStudent = new Student();
                newStudent.Name = TextName.Text;
                newStudent.Id = Int32.Parse(TextID.Text);
                newStudent.GPA = float.Parse(TextGPA.Text);
                students.Add(newStudent);
                MessageBox.Show("Student added");
            }
            RefreshData();
        }

        private void RefreshData()
        {
            TextName.Clear();
            TextID.Clear();
            TextGPA.Clear();
            StudentGrid.DataSource = null;
            StudentGrid.DataSource = students;

        }
        private void RemovePersonButton_Click(object sender, EventArgs e)
        {
            var studentRemove = StudentGrid.CurrentRow.Cells[0].Value;
            var result = MessageBox.Show($"Are you sure you want to delete {studentRemove}?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                students.RemoveAt(StudentGrid.CurrentRow.Index);
                RefreshData();
                StudentGrid.DataSource = null;
                MessageBox.Show("Record deleted");
                StudentGrid.DataSource = students;
            }

        }
        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}