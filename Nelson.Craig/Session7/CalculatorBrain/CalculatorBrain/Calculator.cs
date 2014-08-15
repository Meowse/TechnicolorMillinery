using System.ComponentModel;
using System.Diagnostics;

namespace CalculatorBrain
{
    public class Calculator
    {
        private string _currentValue = "0";
        private string _storedValue = "";
        public bool _hasDecimal = false;
        private bool _AppendState = true;
        private bool _AddState = false;
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
            _currentValue = _currentValue + characterinput.ToString();
        }

        private void OperatorInput(char operate)
        {
            
        }
        public void ProvideInput(char input)
        {
            switch (input)
            {
                case 'c':
                    _currentValue = _currentValue + "0";
                    break;
                case '.':
                    if (_hasDecimal == false)
                    {
                        _currentValue = _currentValue + ".";
                        _hasDecimal = true;
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
                    _AppendState = false;
                    _AddState = true;
                    _currentValue = "+";
                    break;
                default:
                    break;
            }

                GetDisplay();
            
            
        }

        public string GetDisplay()
        {
            if (_currentValue != null)
            {
                decimal currentValueAsNumber = decimal.Parse(_currentValue);
                return currentValueAsNumber.ToString();
            }
            else
            {
                return "";
            }
        }

    }
}
