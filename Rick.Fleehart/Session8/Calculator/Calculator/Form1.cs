using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        
        private char _firstInput = '0';   //first number entered
        private char _secondInput = '0';  //Second number entered

        private char _operator = '0';  // the + - * / c ce operators
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
            RunningDisplay.Text = "0";
            _theRunningDisplay = ""; //clear the running display variable
        }

        public void ClearDisplayResults()
        {
            // clears the the bottom input field in
            DisplayResults.Text = "0";
        }


        public void DealWithNumbers(char theInput)
        {
            if (_firstInput.Equals('0'))
            {
                //if this is the first number entered, then fill the _firstInput variable
                _firstInput = theInput; //first number entered
            }
            else
            {
                //if this is the second number entered, then fill the _secondInput variable
                 _secondInput = theInput;  //Second number entered
            }
            
           
        }

        public void DealWithEqualSign()
        {
            decimal _calculatedValue = 9; //private by default to hold the calculation


            // show the calculated output in DisplayResults
            DisplayResults.Text = _calculatedValue.ToString();

            // put the equals sign then [calculated results] in RunningDisplay
            RunningDisplay.Text = "=";

            // put the [calculated results] in RunningDisplay -only works for single calculated values, so far
            // to deal with 2 or three digit results loop through the chars of the [calculated results]
            RunningDisplay.Text = _calculatedValue.ToString();

            //after calculating, clean-up: clear the first and second variables
            _firstInput = '0'; //first number entered
            _secondInput = '0';  //Second number entered
            _operator = '0';

        }


        public void DoStuffToinput(char theInput)
        {
            switch (theInput)
            {
                // do not show operators on screen but set the _operator switch to the operator
                case '+':
                case '-':
                case 'x':
                case '/':
                    _operator = theInput; // 
                    DisplayToRunningDisplay(theInput); 
                    // display the operator in the running display
                    // do not show operators in RunningDisplay or the results screen
                    break;

                case '=':
                    // the equal sign calculates everything
                    DealWithEqualSign();
                    break;

                case 'c':
                    //Clear entry
                    ClearDisplayResults();
                    ClearRunningDisplay();
                    break;

                case 'e':
                    // -------------------- not functioning yet ------------------
                    // CE on the button, this should remove only the last char  
                    ClearDisplayResults();
                    ClearRunningDisplay();
                    break;

                // do stuff with the numbers
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':

                    DisplayToScreen(theInput);
                    DisplayToRunningDisplay(theInput);
                    break;


                // if it gets here then just display it for debugging
                default:
                    
                    DisplayToScreen(theInput);
                    DisplayToRunningDisplay(theInput);
                    break;
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
            // this is Shows CE on the button
            DoStuffToinput('e');
        }



        // cant delete it cant use it---------------------------------------
        private void DisplayResults_TextChanged(object sender, EventArgs e)
        {
            // not used
        }
        
    }
}
