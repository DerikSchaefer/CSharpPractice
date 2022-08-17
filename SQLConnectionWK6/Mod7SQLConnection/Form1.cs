using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod7SQLConnection
{
    public partial class Form1 : Form
    {

        EmpRepository empRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empRepository = new EmpRepository();
            EmpGrid.DataSource = empRepository.GetAllRecords();
            EmpGrid.Columns[4].Visible = false;
            EmpGrid.Columns[5].Visible = false;
            BtnUpdate.Visible = false; 
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtEID.Clear();
            txtEID.Text = (empRepository.GetMaxId() + 1).ToString();
            txtEID.ReadOnly = true;
            txtName.Clear();
            txtEmpSalary.Clear();
            foreach (var d in empRepository.GetAllDepartTable()) 
            {
                ComboDepartment.Items.Add(d.DeptName);
            }
            BtnSubmit.Enabled = true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEID.Text) && !string.IsNullOrEmpty(txtName.Text))
            {
                if (ComboDepartment.SelectedIndex != -1)
                {
                    var newEmp = new Employee();
                    newEmp.EmployeeId = Int32.Parse(txtEID.Text);
                    newEmp.EmployeeName = txtName.Text;
                    newEmp.EmpSalary = decimal.Parse(txtEmpSalary.Text);
                    newEmp.DeptId = ComboDepartment.SelectedIndex + 1;
                    empRepository.AddRecord(newEmp);
                    MessageBox.Show("New Employee Added!");
                    foreach (var emp in empRepository.GetAllRecords())
                    {
                        foreach (var d in empRepository.GetAllDepartTable()) 
                        {
                            if (emp.DeptId == d.DeptId)
                            {
                                emp.DeptName = d.DeptName;
                            }
                        }
                    }
                }
            }
            Clear();
        }

        private void Clear()
        {
            txtEID.Clear();
            txtName.Clear();
            txtEmpSalary.Clear();
            ComboDepartment.SelectedIndex = -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            EmpGrid.DataSource = null;
            EmpGrid.DataSource = empRepository.GetAllRecords();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var id = EmpGrid.CurrentRow.Cells[1].Value;
            var empToDel = empRepository.FindEmployee((int)id);
            empRepository.DeleteRecord(empToDel);
            MessageBox.Show("Record deleted");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = EmpGrid.CurrentRow.Cells[1].Value;
            var empToUpdate = empRepository.FindEmployee((int)id);
            txtEID.Text = empToUpdate.EmployeeId.ToString();
            txtEID.ReadOnly = true;
            txtName.Text = empToUpdate.EmployeeName;
            txtEmpSalary.Text = empToUpdate.EmpSalary.ToString(); 

            foreach (var i in empRepository.GetAllDepartTable())
            {
                ComboDepartment.Items.Add(i.DeptName);
                if (i.DeptId == empToUpdate.DeptId)
                {
                    ComboDepartment.SelectedItem = i.DeptName;
                }
            }
            BtnUpdate.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtEID.Text); 
            var empToUpdate = empRepository.FindEmployee((int)id);
            empToUpdate.EmployeeName = txtName.Text;
            empToUpdate.EmpSalary = decimal.Parse(txtEmpSalary.Text);
            empToUpdate.DeptId = ComboDepartment.SelectedIndex + 1;
            empRepository.UpdateRecord(id, empToUpdate);
            MessageBox.Show("Record has been updated!");
            Clear();

            // to update the property from our temp list of employees

            foreach (var emp in empRepository.GetAllRecords())
            {
                foreach (var d in empRepository.GetAllDepartTable())
                {
                    if (emp.DeptId == d.DeptId)
                    {
                        emp.DeptName = d.DeptName;
                    }
                }
            }
           
        }
    }
}
