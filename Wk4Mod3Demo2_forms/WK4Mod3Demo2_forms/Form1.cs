using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WK4Mod3Demo2_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Event handler. What you want to do when the form gets loaded is decided here 
            MessageBox.Show("Welcome to Winforms!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
            label1.Text = "Welcome! " + txtName1.Text;
        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
