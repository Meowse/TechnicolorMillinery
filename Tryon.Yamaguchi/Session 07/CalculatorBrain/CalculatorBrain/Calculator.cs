using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBrain
{
    public class Calculator
    {
        private string _currentValue = "";
        private decimal _totalValue;
        private char _mathSymbol;

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
        public void ProvideInput(char input)
        {
            switch (input)
            {
                case 'C':
                    _currentValue = "0";
                    _totalValue = 0;
                    break;
                case '1':
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '2':
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '3':
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '4':
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '5':
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '6':
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '7':
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '8':
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '.':
                    if (_currentValue.Contains("."))
                    {
                        //Do nothing because 2nd decimal is invalid
                    }
                    else
                    {
                        _currentValue = _currentValue + input.ToString();
                    }

                    break;
                case '0':
                    decimal checkZero = decimal.Parse(_currentValue);

                    if (checkZero > 0)
                    {
                        _currentValue = _currentValue + input.ToString();
                    }
                    break;
                case '+':

                    if (_mathSymbol == '+')
                    {
                        _totalValue = _totalValue + convertValueToDecimal(_currentValue);
                        _currentValue = "";
                    }
                    else
                    {
                        _totalValue = convertValueToDecimal(_currentValue);
                        _currentValue = "";
                        _mathSymbol = '+';
                        
                    }
                   
                    break;
                case '-':

                    if (_mathSymbol == '-')
                    {
                        _totalValue = _totalValue - convertValueToDecimal(_currentValue);
                        _currentValue = "";
                    }
                    else
                    {
                        _totalValue = convertValueToDecimal(_currentValue);
                        _currentValue = "";
                        _mathSymbol = '-';

                    }
                    
                    break;
                case '*':
                    if (_mathSymbol == '*')
                    {
                        _totalValue = _totalValue * convertValueToDecimal(_currentValue);
                        _currentValue = "";
                    }
                    else
                    {
                        _totalValue = convertValueToDecimal(_currentValue);
                        _currentValue = "";
                        _mathSymbol = '*';

                    }
                   
                    break;
                case '/':
                    if (_mathSymbol == '/')
                    {
                        _totalValue = _totalValue / convertValueToDecimal(_currentValue);
                        _currentValue = "";
                    }
                    else
                    {
                        _totalValue = convertValueToDecimal(_currentValue);
                        _currentValue = "";
                        _mathSymbol = '/';

                    }
                  
                    break;
                case '=':

                    _totalValue = _totalValue + convertValueToDecimal(_currentValue);
                    _currentValue = _totalValue.ToString();
                    break;
                
                default:
                    
                    Console.WriteLine("Error - Character not recognize");
                    break;


            }
   
            
        }

        public string GetDisplay()
        {
            
            decimal currentValueAsDecimal = decimal.Parse(_currentValue);
            return currentValueAsDecimal.ToString();
        }

        public decimal convertValueToDecimal(string currentValue)
        {
            decimal convertedValue = decimal.Parse(currentValue);
            return convertedValue;

        }

    }
}
