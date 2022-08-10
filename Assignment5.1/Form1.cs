using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._1
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char
        function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void btn0_Click_1(object sender, EventArgs e)
        {

            CalcDisplay.Text = "";
            userInput += "0";
            CalcDisplay.Text += userInput;

        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "1";
            CalcDisplay.Text += userInput;
        }
        private void btn2_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "2";
            CalcDisplay.Text += userInput;
        }
        private void btn3_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "3";
            CalcDisplay.Text += userInput;
        }
        private void btn4_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "4";
            CalcDisplay.Text += userInput;
        }
        private void btn5_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "5";
            CalcDisplay.Text += userInput;
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "6";
            CalcDisplay.Text += userInput;
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "7";
            CalcDisplay.Text += userInput;
        }
        private void btn8_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "8";
            CalcDisplay.Text += userInput;
        }
        private void btn9_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "9";
            CalcDisplay.Text += userInput;
        }
        private void decimalButton_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += ".";
            CalcDisplay.Text += userInput;
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            switch (function)
            {
  
                case '+':
                    result = firstNum + secondNum;
                    CalcDisplay.Text = result.ToString();
                    break;
   
                case '-':
                    result = firstNum - secondNum;
                    CalcDisplay.Text = result.ToString();
                    break;
                case '/':
                    if (secondNum == 0 || firstNum == 0)
                    {
                        CalcDisplay.Text = "Don't do that, you're going to break the internet";
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        CalcDisplay.Text = result.ToString();
                    }
                    break;
                case '*':
                    result = firstNum * secondNum;
                    CalcDisplay.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            CalcDisplay.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}