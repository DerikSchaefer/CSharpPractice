using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textUserID.Text == "Teacher" && textPassword.Text == "Admin")
            {
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();
            }
            else
            {
                pictureBox1.Show();
                textUserID.Clear();
                textPassword.Clear();
                MessageBox.Show("Try again");
                pictureBox1.Hide();
            }
        }
    }
}