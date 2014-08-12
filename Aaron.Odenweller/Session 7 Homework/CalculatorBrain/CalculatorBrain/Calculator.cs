using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculatorBrain
{
    public class Calculator
    {
        private decimal number;
        private string display;
        private char operation;


        public bool DecimalValueEntered(string value)
        {

            bool decimalEntered = true;

            try
            {
                decimal.Parse(value);

            }
            catch (Exception)
            {
                decimalEntered = false;
            }

            return decimalEntered;

        }

        public void setNumber(string inputNumber)
        {
            this.number = decimal.Parse(inputNumber);
        }

        // The current state of the calculator will have to be stored somehow
        // in instance variables, here, declared directly inside the "Calculator"
        // scope.

        /*
         * Valid inputs:
         * '0' -- input the digit 0
         * ...
         * '9' -- input the digit 9
         * '+' -- add
         * '-' -- subtract
         * '*' -- multiply
         * '/' -- divide
         * '=' -- perform the current calculation
         * 'c' -- clear
         */

        public void setOperation(string aOperation)
        {

            this.operation = Convert.ToChar(aOperation.Trim());
        }

        public void PerformOperation(string input)
        {

            switch (this.operation)
            {
                case '+':
                    AddNumbers(decimal.Parse(input));
                    //ClearDisplay();
                    SetDisplay(" + " + input);
                    break;

                case '-':
                    SubtractNumbers(decimal.Parse(input));
                    //ClearDisplay();
                    SetDisplay(" - " + input);
                    break;

                case '*':
                    MultiplyNumber(decimal.Parse(input));
                    //ClearDisplay();
                    SetDisplay(" * " + input);
                    break;

                case '/':
                    DivideNumbers(decimal.Parse(input));

                    break;

                case '=':
                    //ClearDisplay();
                    SetDisplay("The value is now: " + number.ToString());
                    break;

                case 'c':
                    ClearMemory();
                    ClearDisplay();
                    //SetDisplay("This has been cleared.  The value of the calculator is now: " + number.ToString());
                    break;

                default:
                    ClearDisplay();
                    SetDisplay("Enter a Valid Character");
                    break;
            }
        }

        public void SetDisplay(String setDisplayValue)
        {
            display += setDisplayValue;
        }


        public string GetDisplay(Calculator calcObject)
        {

            return calcObject.display;
        }

        public void ClearMemory()
        {
         this.number = 0;
        }
        public void ClearDisplay()
        {
            this.display = "";
        }

        public void AddNumbers(decimal secondNumber)
        {
            decimal tempDecimal = this.number;
            this.number = tempDecimal + secondNumber;
        }

        public void SubtractNumbers(decimal secondNumber)
        {
            decimal tempDecimal = this.number;
            this.number = tempDecimal - secondNumber;
        }

        public void DivideNumbers(decimal secondNumber)
        {
            if (secondNumber != 0)
            {
                decimal tempDecimal = this.number;
                this.number = tempDecimal/secondNumber;
                //ClearDisplay();
                SetDisplay(" / " + secondNumber);
            }

            else
            {
                ClearDisplay();
                SetDisplay("Cannot Divide By Zero");
            }
        }

        public void MultiplyNumber(decimal secondNumber)
        {
            decimal tempDecimal = this.number;
            this.number = tempDecimal * secondNumber;
        }
    }
}
