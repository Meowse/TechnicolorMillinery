using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;

namespace CalculatorBrainGuts
{
    public class CalculatorBrain
    {
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
         * 
         * Calculator app notes
            char firstInput;
            char secondInput;
            char Operator;
            string currentState;  saves state: nothing, first, second, operator
            string currentDisplay;
            DisplayIt(currentDisplay);
            DisplayIt(string toDisplay) { 
                ScreenDisplay.text = toDisplay;
            }
            Button push: 0-9   Numbers 
            Button push: c   Clear
            Button push: +   Addition
            Button push: -   Subtract
            Button push: /   Divide
            Button push: *   Multiply
            Button push: .  Decimal
         */

        public void ProvideInput(char input)
        {
            // accepts one char at a time 
        }

        public string GetDisplay()
        {

            return CalculatorForm.DisplayResults.Text;
        } 
    }
}
