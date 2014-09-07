using System;
using System.Windows.Forms;
using CalculatorBrain;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        readonly Calculator _calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void Button1_click(object sender, EventArgs e)
        {
            HandleInput('1');
        }

        private void Button2_click(object sender, EventArgs e)
        {
            HandleInput('2');
        }

        private void Button3_click(object sender, EventArgs e)
        {
            HandleInput('3');
        }

        private void Button4_click(object sender, EventArgs e)
        {
            HandleInput('4');
        }

        private void Button5_click(object sender, EventArgs e)
        {
            HandleInput('5');
        }

        private void Button6_click(object sender, EventArgs e)
        {
            HandleInput('6');
        }

        private void Button7_click(object sender, EventArgs e)
        {
            HandleInput('7');
        }

        private void Button8_click(object sender, EventArgs e)
        {
            HandleInput('8');
        }

        private void Button9_click(object sender, EventArgs e)
        {
            HandleInput('9');
        }

        private void Button0_click(object sender, EventArgs e)
        {
            HandleInput('0');
        }

        private void Point_click(object sender, EventArgs e)
        {
            HandleInput('.');
        }

        private void Plus_click(object sender, EventArgs e)
        {
            HandleInput('+');
        }

        private void Minus_click(object sender, EventArgs e)
        {
            HandleInput('-');
        }

        private void Divide_click(object sender, EventArgs e)
        {
            HandleInput('/');
        }

        private void Times_click(object sender, EventArgs e)
        {
            HandleInput('*');
        }

        private void Clear_click(object sender, EventArgs e)
        {
            HandleInput('c');
        }

        private void equals_click(object sender, EventArgs e)
        {
            HandleInput('=');
        }

        private void HandleInput(char input)
        {
            _calculator.ProvideInput(input);
            Displaybox.Text = _calculator.GetDisplay();
        }

        private void leftParenButton_Click(object sender, EventArgs e)
        {
            HandleInput('(');
        }

        private void rightParenButton_Click(object sender, EventArgs e)
        {
            HandleInput(')');
        }
    }
}
