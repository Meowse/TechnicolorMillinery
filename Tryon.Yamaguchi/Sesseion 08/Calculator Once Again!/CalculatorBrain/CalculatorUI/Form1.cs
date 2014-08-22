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

namespace CalculatorUI
{
    public partial class frmCalculator : Form
    {

        readonly Calculator _calculator = new Calculator();
        public frmCalculator()
        {
            InitializeComponent();
        }


        private void HandleInput(char input)
        {
            _calculator.ProvideInput(input);
            txtDisplay.Text = _calculator.GetDisplay();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            HandleInput('1');
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            HandleInput('.');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            HandleInput('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            HandleInput('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            HandleInput('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            HandleInput('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            HandleInput('6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            HandleInput('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            HandleInput('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            HandleInput('9');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            HandleInput('/');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            HandleInput('*');
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            HandleInput('-');
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HandleInput('+');
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            HandleInput('=');
        }

        private void btnC_Click(object sender, EventArgs e)
        {
           HandleInput('C');
        }
    }
}
