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

        // lists, details at http://www.dotnetperls.com/list
        // below is one way to do a list
        //List<int> list = new List<int>();
        //list.Add(2);
        //list.Add(3);
        //Counting members of a list: list.Count
        //list.Clear()

        //add each inputed char to one element of the list
        private List<decimal> _inputedNumbersList = new List<decimal>(); //All numbers go into this as a list

        private List<char> _inputedOperatorsList = new List<char>(); // all the operators go into this list
      

        // below are for version 1
        private Int32 _firstInput = 999;   //first number entered, 999 is default flag
        private Int32 _secondInput = 999;  //Second number entered, 999 is default flag

        private char _operator = '0';  // the + - * / c ce operators

        //private string _theRunningDisplay;
         
        
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


        public void DealWithNumbers(char theInput)
        {
            if (_firstInput.Equals(999))
            {
                //if this is the first number entered x by defalt, then fill the _firstInput variable
                _firstInput = Int32.Parse(theInput.ToString()); //convert from char to a number, first number entered
         
                //clear the = from the operation display
                ClearOperationDisplay();
            }
            else
            {
                //if this is the second number entered, then fill the _secondInput variable
                _secondInput = Int32.Parse(theInput.ToString());  //convert from char to a number, Second number entered
            }
            
           
        }

        public void DealWithEqualSign()
        {
            decimal calculatedValue; //private by default to hold the calculation

            switch (_operator)
            {
                    // assume the first and second variables are populated
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
                    // deal with divide by zero
                    calculatedValue = (decimal) _firstInput / _secondInput;

                    break;

                default:
                    // just in case, will show like an error
                    calculatedValue = 999;

                    break;

                    
            }


            // show the calculated output in DisplayResults
            DisplayResults.Text = calculatedValue.ToString();

            //after calculating, clean-up: set the first, second and operator variables to 999, 0 or x as a flag
            _firstInput  = 999; //first number entered, set to the nothing here flag of x
            _secondInput = 0;   //Second number entered, set to the nothing here flag of x
            _operator    = 'x'; // set to the nothing here flag of x
             

        }


        public void DoStuffToinput(char theInput)
        {
            switch (theInput)
            {
                // do not show operators on screen but set the _operator switch to the operator char
                case '+':
                case '-':
                case 'x':
                case '/':
                    _operator = theInput; // char variable
                     
                    // do not show operators in bottom results screen

                    // display the operator
                    ShowOperationDisplay(theInput);
                    break;

                case '=':
                    // the equal sign calculates everything
                    DealWithEqualSign();

                    // display the operator
                    ShowOperationDisplay(theInput);
                    break;

                case 'c':
                    //Clear entry
                    ClearDisplayResults();

                    ClearOperationDisplay();
                    break;

                case 'e':
                    // -------------------- not functioning yet ------------------
                    // CE on the button, this should remove only the last char  
                    ClearDisplayResults();

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
                    // numbers 0-9 above all do this, below:
                    DealWithNumbers(theInput); // this stores the number, etc

                    DisplayToScreen(theInput);
   
                    break;

                case '.':
                    //can't deal with decimals in version 1
                    break;

                // if it gets here then just display it for debugging
                default:
                    
                    DisplayToScreen(theInput);
  
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
