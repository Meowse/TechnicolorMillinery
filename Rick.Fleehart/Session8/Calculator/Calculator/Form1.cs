using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// CS from the Form ---------------------------------

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        public void DisplayToScreen(char theInput)
        {
            // put theInput into the field in the form
            DisplayResults.Text = theInput.ToString();
        }

        public void DoStuffToinput(char theInput)
        {
            // save inputs and do calculations
            DisplayToScreen(theInput);
        }





        // Below are the button click functions -----------------
        private void buttonZero_Click(object sender, EventArgs e)
        {
            DoStuffToinput('0');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoStuffToinput('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoStuffToinput('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoStuffToinput('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoStuffToinput('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoStuffToinput('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoStuffToinput('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DoStuffToinput('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DoStuffToinput('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DoStuffToinput('9');
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            DoStuffToinput('.');
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            DoStuffToinput('+');
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            DoStuffToinput('-');
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            DoStuffToinput('x');
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            DoStuffToinput('/');
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            DoStuffToinput('=');
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DoStuffToinput('0');
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            DoStuffToinput('0');
        }



        // cant delete it cant use it---------------------------------------
        private void DisplayResults_TextChanged(object sender, EventArgs e)
        {
            // not used
        }
        
    }
}
