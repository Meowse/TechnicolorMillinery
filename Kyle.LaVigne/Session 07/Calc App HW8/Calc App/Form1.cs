using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_App
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "+";
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "*";
            input = string.Empty;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "-";
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "/";
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
        }

    }

}
