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

        private string _inputedNumbers = ""; //the chars get assembled here

        private char _operator = '0';  // the + - * / c ce are the allowed operators

        private decimal _firstInput = 0;   //first number entered, 999 is default flag
        private decimal _secondInput = 0;  //Second number entered, 999 is default flag


        public void DoStuffToinput(char theInput)
        {
            switch (theInput)
            {
                // do not show operators on screen but set the _operator switch to the operator char
                case '+':
                case '-':
                case 'x':
                case '/':

                    _firstInput = decimal.Parse(_inputedNumbers);
                    // convert the string of numbers into a decimal real number

                    _inputedNumbers = ""; //clear the var for the next chars

                    _operator = theInput; //set the operator variable

                    // display the operator
                    ShowOperationDisplay(_operator);
                    break;

                case '=':
                    // the equal sign calculates everything

                    DealWithEqualSign();

                    break;

                case 'c':
                    //Clear entry
                    ClearDisplayResults();

                    ClearNumberVariables();

                    ClearOperationDisplay();
                    break;

                case 'e':
                    // -------------------- not functioning yet ------------------
                    // CE on the button, this should remove only the last char  
                    ClearDisplayResults();

                    ClearNumberVariables();

                    ClearOperationDisplay();
                    break;

                // do stuff with the numbers: DealWithNumbers(theInput)
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
                case '.':
                    // numbers 0-9 and decimal above all do this, below:
                    DealWithNumbers(theInput); // this stores the number, etc

                    DisplayStringToScreen(_inputedNumbers); //_inputedNumbers is accumulation of chars

                    break;

                // if it gets here then just display it for debugging
                default:

                    DisplayStringToScreen(_inputedNumbers);

                    break;
            }

        }


        public void DealWithNumbers(char theInput)
        {
            if (_firstInput == 0)
            {
                //this is the first number entered clear the operation display from last operation
                //clear the = from the operation display
                ClearOperationDisplay();
            }

            if (theInput == '.' && _inputedNumbers.Contains('.'))
            {
                // do nothing, don't add the second decimal point
            }
            else 
            { 
                _inputedNumbers = _inputedNumbers + theInput; //add the chars in to decimal until an operator is pressed
            }
        }


        public void DealWithEqualSign()
        {
            // the equals sign has been pressed calculate then clean up

            decimal calculatedValue = 0; //holds the calculation


            // the first number is already in _firstInput and is added in DealWithNumbers()
            _secondInput = decimal.Parse(_inputedNumbers);

            switch (_operator)
            {
                 
                case '+':
                    // calc two ints into the decimal variable calculatedValue
                    calculatedValue = _firstInput + _secondInput;

                    break;

                case '-':
                    calculatedValue = _firstInput - _secondInput;

                    break;

                case 'x':
                    calculatedValue = _firstInput * _secondInput;

                    break;

                case '/':

                    // needs to be able to deal with divide by zero
                    if (_secondInput == 0)
                    {
                        //do not calc
                        calculatedValue = 99999999;
                    }
                    else
                    {
                        calculatedValue = (decimal)_firstInput / _secondInput;  
                    }
                    
       
                    break;

                default:
                    // just in case, will show like an error
                    calculatedValue = 99999999;

                    break;

            }


            // show the calculated output in DisplayResults
            DisplayResults.Text = calculatedValue.ToString();

            ShowOperationDisplay('=');

            ClearNumberVariables(); // clear out and reset
        }


        



        //--------- display and clear section -------------------------------
        public void DisplayStringToScreen(string whatToDisplay)
        {
            // put whatToDisplay into the field in the form
            DisplayResults.Text = whatToDisplay;
        }



        public void DisplayToScreen(char theInput)
        {
            // put theInput into the field in the form
            DisplayResults.Text = theInput.ToString();
        }

        public void ShowOperationDisplay(char theInput)
        {
            //show the operator in the small field on the upper left of the results field
            OperationDisplay.Text = theInput.ToString();
        }

        public void ClearOperationDisplay()
        {
            OperationDisplay.Text = "";
        }


        public void ClearDisplayResults()
        {
            // sets the DisplayResults input field to "0"
            DisplayResults.Text = "0";
        }

        public void ClearNumberVariables()
        {
            _inputedNumbers = "";
            _secondInput    = 0;
            _firstInput     = 0;
            //_operator       ='0';

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
