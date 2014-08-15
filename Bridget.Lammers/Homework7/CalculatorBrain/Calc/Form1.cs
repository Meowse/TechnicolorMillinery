using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorBrain;

namespace Calc
{
    public partial class Form1 : Form
    {
        readonly Calculator _calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void HandleInput(char input)
        {
            _calculator.ProvideInput(input);
            display.Text = _calculator.GetDisplay();
        }

        private void buttonFor1_Click(object sender, EventArgs e)
        {
            HandleInput('1');
        }

        private void buttonFor2_Click(object sender, EventArgs e)
        {
            HandleInput('2');
        }

        private void buttonFor3_Click(object sender, EventArgs e)
        {
            HandleInput('3');
        }

        private void buttonForClear_Click(object sender, EventArgs e)
        {
            HandleInput('c');
        }

        private void key0_Click(object sender, EventArgs e)
        {
            HandleInput('0');
        }

        private void keyDecimal_Click(object sender, EventArgs e)
        {
            HandleInput('.');
        }

        private void key4_Click(object sender, EventArgs e)
        {
            HandleInput('4');
        }

        private void key5_Click(object sender, EventArgs e)
        {
            HandleInput('5');
        }

        private void key6_Click(object sender, EventArgs e)
        {
            HandleInput('6');
        }
    }
}
