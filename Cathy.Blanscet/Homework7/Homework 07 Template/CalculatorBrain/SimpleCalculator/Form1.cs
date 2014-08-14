using System;
using System.Windows.Forms;
using CalculatorBrain;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Calculator _calc = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        public void GetInput(char input)
        {
            _calc.ProvideInput(input);
            txtBxDisplay.Text = _calc.GetDisplay();
        }

        //the buttons for the calculator
        private void btn0_clicked(object sender, EventArgs e)
        {
            GetInput('0');
        }
        private void btn1_clicked(object sender, EventArgs e)
        {
            GetInput('1');
        }
        private void btn2_clicked(object sender, EventArgs e)
        {
            GetInput('2');
        }
        private void btn3_clicked(object sender, EventArgs e)
        {
            GetInput('3');
        }
        private void btn4_clicked(object sender, EventArgs e)
        {
            GetInput('4');
        }
        private void btn5_clicked(object sender, EventArgs e)
        {
            GetInput('5');
        }
        private void btn6_clicked(object sender, EventArgs e)
        {
            GetInput('6');
        }
        private void btn7_clicked(object sender, EventArgs e)
        {
            GetInput('7');
        }
        private void btn8_clicked(object sender, EventArgs e)
        {
            GetInput('8');
        }
        private void btn9_clicked(object sender, EventArgs e)
        {
            GetInput('9');
        }
        private void btnClr_clicked(object sender, EventArgs e)
        {
            GetInput('c');
        }
        private void btnDot_clicked(object sender, EventArgs e)
        {
            GetInput('.');
        }
    }
}
