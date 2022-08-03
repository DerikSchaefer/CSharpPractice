using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Wk4Mod3_Demo3_Employee
{
    public partial class Form1 : Form
    {
        List<Employee> employees;    
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { Eid = 1, FirstName = "Ian", LastName = "Smith", Salary = 3444, Dept = Department.Marketing});
            employees.Add(new Employee() { Eid = 2, FirstName = "Jim", LastName = "Schaefer", Salary = 3444, Dept = Department.IT });
            employees.Add(new Employee() { Eid = 3, FirstName = "Joe", LastName = "Brown", Salary = 3444, Dept = Department.Finance });
            EmpGrid.DataSource = employees;
            BoxDept.DataSource = Enum.GetValues(typeof(Department));
            EmpGrid.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpGrid.Visible = true;
            if (txtEid.Text != String.Empty && txtFName.Text != String.Empty && txtLName.Text != String.Empty)
            {
                Employee newEmp = new Employee();
                newEmp.Eid = Int32.Parse(txtEid.Text);
                newEmp.FirstName = txtFName.Text;   
                newEmp.LastName = txtLName.Text;
                newEmp.Salary = Int32.Parse(txtSalary.Text);
                // type casting // explicit conversion required 
                newEmp.Dept = (Department)BoxDept.SelectedIndex;
                employees.Add(newEmp);
                MessageBox.Show("Record added");
            }
            RefreshData();
        }
        private void RefreshData()
        {
            txtEid.Clear();
            txtFName.Clear();
            txtLName.Clear();
            BoxDept.SelectedIndex = -1;
            EmpGrid.DataSource = null;
            EmpGrid.DataSource = employees;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            employees.RemoveAt(EmpGrid.CurrentRow.Index);
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
