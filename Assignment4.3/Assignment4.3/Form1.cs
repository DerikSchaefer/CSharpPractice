using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._3
{
    public partial class Form1 : Form
    {

        List<Students> students;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<Students>();
            students.Add(new Students() { StudentId = 1, FirstName = "Robert", LastName = "Elizalde", Address = "2908 Coal Street", Grade = 'A', monthOfAdmission = MonthOfAdmission.April });
            students.Add(new Students() { StudentId = 2, FirstName = "Esther", LastName = "Gettinger", Address = "1980 Mulberry Lane", Grade = 'B', monthOfAdmission = MonthOfAdmission.March });
            students.Add(new Students() { StudentId = 3, FirstName = "Christie", LastName = "Parker", Address = "3773 Wayback Lane", Grade = 'A', monthOfAdmission = MonthOfAdmission.November });
            students.Add(new Students() { StudentId = 4, FirstName = "Betty", LastName = "Mora", Address = "3361 West Fork Street", Grade = 'C', monthOfAdmission = MonthOfAdmission.September });
            StudentGrid.DataSource = students;
            BoxMonth.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textID.Text != String.Empty && textFName.Text != String.Empty && textLName.Text != String.Empty && textAddress.Text != String.Empty && textGrade.Text != String.Empty)
            {
                Students newStudent = new Students();
                newStudent.StudentId = Int32.Parse(textID.Text);
                newStudent.FirstName = textFName.Text;
                newStudent.LastName = textLName.Text;
                newStudent.Address = textAddress.Text;
                newStudent.Grade = char.Parse(textGrade.Text);
                newStudent.monthOfAdmission = (MonthOfAdmission)BoxMonth.SelectedIndex;
                students.Add(newStudent);
                MessageBox.Show("Record added");
            }
            RefreshData();
        }
        private void RefreshData()
        {
            textID.Clear();
            textFName.Clear();
            textLName.Clear();
            textAddress.Clear();
            textGrade.Clear();
            BoxMonth.SelectedIndex = - 1;
            StudentGrid.DataSource = null;
            StudentGrid.DataSource = students;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            students.RemoveAt(StudentGrid.CurrentRow.Index);
            RefreshData();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}