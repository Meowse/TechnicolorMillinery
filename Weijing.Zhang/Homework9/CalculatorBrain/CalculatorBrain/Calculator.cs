using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBrain
{
    public class Calculator
    {
        // The current accumulator of the calculator will have to be stored somehow
        // in instance variables, here, declared directly inside the "Calculator"
        // scope.

        private ulong accumulator = 0;
        private string op = "";
        private ulong number = 0;
        private string numberString = "";
        private string currentDisplay = "0";

        /*
         * Valid inputs:
         * '0' -- number the digit 0
         * ...
         * '9' -- number the digit 9
         * '+' -- add
         * '-' -- subtract
         * '*' -- multiply
         * '/' -- divide
         * '=' -- perform the current calculation
         * 'c' -- clear
         */
        public void ProvideInput(char input)
        {
            if (input == 'c' || input == 'C')
            {
                ClearMemory();
                currentDisplay = accumulator.ToString();
                return;
            }

            if (IsNumber(input))
            {
                numberString = numberString + input;
                number = ulong.Parse(numberString);
                currentDisplay = number.ToString();
            }
            else if(input == '+' || input == '-' || input =='*' || input == '/')
            {
                UpdateAccumulator();
                currentDisplay = accumulator.ToString();
                op = input.ToString();
                numberString = "";
            }
            else if (input == '=')
            {
                UpdateAccumulator();
                currentDisplay = accumulator.ToString();
                ClearMemory();
            }
            else
            {
                currentDisplay = "Invalid operator: " + input;
                ClearMemory();
            }
        }

        public string GetDisplay()
        {
            return currentDisplay;
        }

        private void ClearMemory()
        {
            accumulator = 0;
            op = "";
            number = 0;
            numberString = "";
        }

        private void UpdateAccumulator()
        {
            switch (op)
            {
                case "":
                    accumulator = number;
                    break;
                case "+":
                    accumulator += number;
                    break;
                case "-":
                    accumulator -= number;
                    break;
                case "*":
                    accumulator *= number;
                    break;
                case "/":
                    accumulator /= number;
                    break;
            }
        }

        private bool IsNumber(char c)
        {
            if (c < '0' || c > '9') return false;
            else return true;
        }
    }
}
