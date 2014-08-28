using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBrain
{
    public class Calculator
    {
        private string _currentValue = "0";
        private decimal _firstValue, _secondValue, _totalValue;
        private char _mathSymbol;
        private Boolean _isSecondValue = false;
        private Boolean _startSecondDisplay = false;
        private Boolean _hasEqual = false;
        private Boolean _symbolFlag = false;



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
            if (_hasEqual == true)
            {
                ResetCalc();
            }
            switch (input)
            {
                case 'C':
                    ResetCalc();
                    break;

                case '1':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '2':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '3':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '4':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '5':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '6':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '7':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '8':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '9':
                    CheckFlags();
                    _currentValue = _currentValue + input.ToString();
                    break;
                case '0':
                    decimal checkZero = decimal.Parse(_currentValue);

                    if (checkZero != 0)
                    {
                        _currentValue = _currentValue + input.ToString();
                    }
                    break;
                case '+':
                    if (_hasEqual == true || _symbolFlag == true)
                    {
                        _totalValue = _totalValue + decimal.Parse(_currentValue);
                        _currentValue = _totalValue.ToString();
                    }
                    else
                    {
                        if (_isSecondValue == true)
                        {
                            _totalValue = _firstValue + decimal.Parse(_currentValue);
                            _currentValue = _totalValue.ToString();

                        }
                        else
                        {
                            _firstValue = decimal.Parse(_currentValue);
                            _isSecondValue = true;
                            _mathSymbol = '+';
                            _startSecondDisplay = true;
                            _symbolFlag = true;
                        }

                    }
                    break;
                case '-':
                    if (_hasEqual == true || _symbolFlag == true)
                    {
                        _totalValue = _totalValue - decimal.Parse(_currentValue);
                        _currentValue = _totalValue.ToString();
                    }
                    else
                    {
                        if (_isSecondValue == true)
                        {
                            _totalValue = _firstValue - decimal.Parse(_currentValue);
                            _currentValue = _totalValue.ToString();

                        }
                        else
                        {
                            _firstValue = decimal.Parse(_currentValue);
                            _isSecondValue = true;
                            _mathSymbol = '-';
                            _startSecondDisplay = true;


                        }
                    }
                    break;
                case '*':
                    if (_hasEqual == true || _symbolFlag == true)
                    {
                        _totalValue = _totalValue * decimal.Parse(_currentValue);
                        _currentValue = _totalValue.ToString();
                    }
                    else
                    {
                        if (_isSecondValue == true)
                        {
                            _totalValue = _firstValue*decimal.Parse(_currentValue);
                            _currentValue = _totalValue.ToString();

                        }
                        else
                        {
                            _firstValue = decimal.Parse(_currentValue);
                            _isSecondValue = true;
                            _mathSymbol = '*';
                            _startSecondDisplay = true;

                        }
                    }
                    break;
                case '/':
                    if (_hasEqual == true || _symbolFlag == true)
                    {
                        _totalValue = _totalValue / decimal.Parse(_currentValue);
                        _currentValue = _totalValue.ToString();
                    }
                    else
                    {


                        if (_isSecondValue == true)
                        {
                            _totalValue = _firstValue/decimal.Parse(_currentValue);
                            _currentValue = _totalValue.ToString();


                        }
                        else
                        {
                            _firstValue = decimal.Parse(_currentValue);
                            _isSecondValue = true;
                            _mathSymbol = '/';
                            _startSecondDisplay = true;

                        }
                    }

                    break;
                case '=':

                    if (_isSecondValue == true)
                    {
                        switch (_mathSymbol)
                        {
                            case '+':
                            {
                                _totalValue = _firstValue + decimal.Parse(_currentValue);
                                break;
                            }
                            case '-':
                            {
                                _totalValue = _firstValue - decimal.Parse(_currentValue);
                                break;
                            }
                            case '*':
                            {
                                _totalValue = _firstValue * decimal.Parse(_currentValue);
                                break;
                            }
                            case '/':
                            {
                                _totalValue = _firstValue / decimal.Parse(_currentValue);
                                break;
                            }
                            default:
                            {
                                break; 
                            }
                                
                        }
                        
                        _hasEqual = true;
                        _currentValue = _totalValue.ToString();


                    }

                    break;
                case '.':
                    if (_currentValue.Contains("."))
                    {
                        //Do nothing because 2nd decimal    is invalid
                    }
                    else
                    {
                        if (_isSecondValue == true && _startSecondDisplay == true)
                        {
                            _currentValue = "";
                            _startSecondDisplay = false;
                        }
                        _currentValue = _currentValue + input.ToString();
                    }

                    break;
                default:
                    break;


            }
   
            
        }

        public string GetDisplay()
        {

            if (_currentValue.Contains("."))
            {
                return _currentValue;
            }

            var currentNumberValue = decimal.Parse(_currentValue, NumberStyles.None);
            return currentNumberValue.ToString();
        }

        public void ResetCalc()
        {
            _currentValue = "0";
            _totalValue = 0;
            _isSecondValue = false;
            _startSecondDisplay = false;
            _mathSymbol = ' ';
            _firstValue = 0;
            _secondValue = 0;
            _hasEqual = false;

        }

        public void CheckFlags()
        {
            if (_hasEqual == true || _symbolFlag==true)
            {
                _currentValue = "";
            }
            else
            {

                if (_isSecondValue == true && _startSecondDisplay == true)
                {
                    _currentValue = "";
                    _startSecondDisplay = false;

                }
            }


        }
    }
}
