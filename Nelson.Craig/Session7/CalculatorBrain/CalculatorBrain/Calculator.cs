using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace CalculatorBrain
{
    public class Calculator
    {
        private string _currentValue = "0";
        private string _storedValue = "";
        private string _operator = "";
        public bool HasDecimal = false;
        private bool _appendState = true;
        private bool _addState = false;
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

        private void AppendInput(char characterinput)
        {
            _appendState = true;
            _currentValue = _currentValue + characterinput;
        }
        private void ApplyOperator()
        {
            if (_operator == "+")
            {
                int result = 0;
                result = Convert.ToInt32(_currentValue) + Convert.ToInt32(_storedValue);
                _storedValue = _currentValue;
                _currentValue = result.ToString();
            }

        }

        private void OperatorInput(char operate)
        {
            _storedValue = _currentValue;
            _currentValue = "";
            _operator = "+";

        }
        public void ProvideInput(char input)
        {
            switch (input)
            {
                case 'c':
                    _currentValue = "0";
                    HasDecimal = false;
                    break;
                case '.':
                    if (HasDecimal == false)
                    {
                        _currentValue = _currentValue + ".";
                        HasDecimal = true;
                    }
                    else
                    {
                        _currentValue = "";
                        
                    }
                    break;
                case '0':
                    AppendInput(input);
                    break;
                case '1':
                    AppendInput(input);
                    break;
                case '2':
                    AppendInput(input);
                    break;
                case '3':
                    AppendInput(input);
                    break;
                case '4':
                    AppendInput(input);
                    break;
                case '5':
                    AppendInput(input);
                    break;
                case '6':
                    AppendInput(input);
                    break;
                case '7':
                    AppendInput(input);
                    break;
                case '8':
                    AppendInput(input);
                    break;
                case '9':
                    AppendInput(input);
                    break;
                case '+':
                    _appendState = false;
                    _addState = true;
                    OperatorInput('+');
                    break;
                case '=':
                    ApplyOperator();
                    break;
            }

            GetDisplay();
            


        }

    
        public string GetDisplay()
        {
            if (_currentValue != null)
            {
                if (_appendState)
                {
                    decimal currentValueAsNumber = decimal.Parse(_currentValue);
                    return currentValueAsNumber.ToString(CultureInfo.InvariantCulture);
                }
                else
                {

                    return _operator.ToString();
                }
                
            }
            return "";
        }
    }
}
