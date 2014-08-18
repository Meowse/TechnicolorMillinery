using System;
using System.Windows.Forms;
using CalculatorBrain;

namespace CalculatorForms
{
    public partial class Form1 : Form
    {
        readonly Calculator _myCalculator = new Calculator();
        public Form1()
        {
            InitializeComponent();

        }

        private void HandleInput(char input)
        {
            _myCalculator.ProvideInput(input);
            TextDisplay.Text = _myCalculator.GetDisplay();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            HandleInput('1');
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            HandleInput('2');
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            HandleInput('3');
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            HandleInput('4');
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            HandleInput('5');
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            HandleInput('6');
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            HandleInput('7');
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            HandleInput('8');
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            HandleInput('9');
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            HandleInput('0');
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (_myCalculator.HasDecimal == false)
            {
                HandleInput('.');
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleInput('c');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleInput('+');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleInput('=');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleInput('-');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleInput('*');
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            HandleInput('/');
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("You pressed the " + e.KeyCode.ToString() + "key");
        }

        

       
    }
}
