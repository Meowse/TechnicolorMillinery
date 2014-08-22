using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// CS in the Form ---------------------------------

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        
        private char firstInput;   //first number entered
        private char secondInput;  //Second number entered

        private char Operator;  // the + - * / c ce operators
        private string _runningTotal;  //Running Total as the calculator goes.

        private string _theRunningDisplay;
         
        
        public void DisplayToScreen(char theInput)
        {
            // put theInput into the field in the form
            DisplayResults.Text = theInput.ToString();
        }

        public void DisplayToRunningDisplay(char theInput)
        {
            // add the new input to the current running chars, then display it all

            //put a space before and after the operator only
            if ((theInput.Equals('+')) || (theInput.Equals('-')) || (theInput.Equals('x')) || (theInput.Equals('/')) || (theInput.Equals('=')))
            {
                _theRunningDisplay = _theRunningDisplay + " " + theInput.ToString() + " ";
            }
            else
            {
                _theRunningDisplay = _theRunningDisplay + theInput.ToString();
            }
            

            // put the (modified) Input into the top field that shows everything
            RunningDisplay.Text = _theRunningDisplay;

        }

        public void ClearRunningDisplay()
        {
            // clears the field in the form and the running variable
            RunningDisplay.Text = "";
            _theRunningDisplay = ""; //clear the running display variable
        }

        public void ClearDisplayResults()
        {
            // clears the the bottom input field in
            DisplayResults.Text = "";
        }

        public void DoStuffToinput(char theInput)
        {
            if (theInput.Equals('c'))
            {
                ClearDisplayResults();
                ClearRunningDisplay();

            }
            else
            {
                DisplayToScreen(theInput);
                DisplayToRunningDisplay(theInput);
            }
           
      
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
            DoStuffToinput('c');
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            DoStuffToinput('e');
        }



        // cant delete it cant use it---------------------------------------
        private void DisplayResults_TextChanged(object sender, EventArgs e)
        {
            // not used
        }
        
    }
}
