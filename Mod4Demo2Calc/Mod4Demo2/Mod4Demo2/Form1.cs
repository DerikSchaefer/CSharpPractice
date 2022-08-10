using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod4Demo2
{
    public partial class Form1 : Form
    {
        ICalculator calculator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(calculator.Add(Int32.Parse(textBox1.Text),Int32.Parse(textBox2.Text)).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculator = new MathCls();
        }
    }
}
