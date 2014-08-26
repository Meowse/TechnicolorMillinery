using System;
using System.Windows.Forms;
using CalculatorBrain;

namespace form
{
    public partial class Form1 : Form
    {
      readonly Calculator _calculator= new Calculator();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void HandleInput(char input)
        {
            _calculator.ProvideInput(input);
            Display.Text = _calculator.GetDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleInput('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleInput('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleInput('3');
        }

        private void buttonforclear_Click(object sender, EventArgs e)
        {
            HandleInput('c');
        }

        private void keyzero_Click(object sender, EventArgs e)
        {
            HandleInput('0');
        }

        private void keydot_Click(object sender, EventArgs e)
        {
            HandleInput('.');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleInput('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleInput('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleInput('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleInput('+');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleInput('-');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleInput('7');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HandleInput('8');
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HandleInput('9');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HandleInput('/');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HandleInput('*');
        }

    }
}
