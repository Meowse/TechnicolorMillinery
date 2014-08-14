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
        // The current state of the calculator will have to be stored somehow
        // in instance variables, here, declared directly inside the "Calculator"
        // scope.

        private string number1 = "";
        private string op = "";
        private string number2 = "";
        private string currentDisplay = "0";

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
        public void ProvideInput(char input)
        {
            if (input == 'c' || input == 'C')
            {
                ClearMemory();
                currentDisplay = "0";
                return;
            }

            if (IsNumber(input))
            {
                if (op == "")
                {
                    number1 = number1 + input;
                    currentDisplay = ulong.Parse(number1).ToString();
                }
                else
                {
                    number2 = number2 + input;
                    currentDisplay = ulong.Parse(number2).ToString();
                }
            }
            else if(input == '+' || input == '-' || input =='*' || input == '/')
            {
                op = input.ToString();
            }
            else if (input == '=')
            {
                if (op == "" || number1 == "" || number2 == "")
                {
                    currentDisplay = "Invalid expression";
                }
                else
                {
                    switch (op)
                    {
                        case "+":
                            currentDisplay = (ulong.Parse(number1) + ulong.Parse(number2)).ToString();
                            break;
                        case "-":
                            currentDisplay = (ulong.Parse(number1) - ulong.Parse(number2)).ToString();
                            break;
                        case "*":
                            currentDisplay = (ulong.Parse(number1) * ulong.Parse(number2)).ToString();
                            break;
                        case "/":
                            currentDisplay = (ulong.Parse(number1) / ulong.Parse(number2)).ToString();
                            break;
                    }
                }
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
            number1 = "";
            number2 = "";
            op = "";
        }

        private bool IsNumber(char c)
        {
            if (c < '0' || c > '9') return false;
            else return true;
        }
    }
}
