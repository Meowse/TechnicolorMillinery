using System;
using System.Globalization;

namespace CalculatorBrain
{
    public class Calculator
    {
        private string _currValu = "0";
        private decimal _num1, _num2;  //, calcValu;
        private char _operation;

        // The current state of the calculator will have to be stored somehow
        // in instance variables, here, declared directly inside the "Calculator"
        // scope.
        private bool _hasOperation;
        private bool _startingSecondNumber;
        private bool _isEqualSign;

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
            if (input == 'c' )
            {
                DoClear();
                //_currValu = "0";
                //_num1 = 0;
                //_num2 = 0;
                //_operation = '0';
                //_hasOperation = false;
                //_startingSecondNumber = false;
            }
            else if (input == '+' || input == '-' || input == '*' || input == '/' )
            {
                DoOperator(input);
                //_num1 = decimal.Parse(_currValu);
                //_operation = input;
                //_hasOperation = true;
                ////_currValu = "0";
            }
            else if (input == '=')
            {
                DoEqualOperator();
                //_num2 = decimal.Parse(_currValu);
                //_currValu= doCalculation().ToString();
                ////switch (operation)
                ////{
                ////    case '+':
                ////        calcValu = num1 + num2;
                ////        CurrValu = calcValu.ToString();
                ////        break;
                ////    case '-':
                ////        calcValu = num1 - num2;
                ////        CurrValu = calcValu.ToString();
                ////        break;
                ////    case '*':
                ////        calcValu = num1 * num2;
                ////        CurrValu = calcValu.ToString();
                ////        break;
                ////    case '/':
                ////        calcValu = num1 / num2;
                ////        CurrValu = calcValu.ToString();
                ////        break;
                ////    default:
                ////        break;
                ////}
            }
            else
            {
                DoDigitsAndDecimal(input);
            }
            //else if (input == '.' && _currValu.Contains("."))
            //{
            //    // do nothing already has the decimal point
            //}
            //else
            //{
            //    if (_currValu == "0")
            //    {
            //        if (input == '.')
            //        {
            //            _currValu = _currValu + input;
            //        }
            //        else
            //        {
            //            _currValu = input.ToString();
            //        }
            //    }
            //    else
            //    {
            //        _currValu = _currValu + input;
            //    }
            //}
        }

        public string GetDisplay()
        {
            //return "0";
            NumberStyles style;
            style = NumberStyles.None;
            decimal CurrValuAsNumber;

            if (_currValu.Contains("."))
            {
                return _currValu;
            }
            CurrValuAsNumber = decimal.Parse(_currValu, style );
            return CurrValuAsNumber.ToString();
        }

        private decimal doCalculation()
        {
            switch (_operation)
            {
                case '+': return _num1 + _num2;
                    //calcValu = num1 + num2;
                    //CurrValu = calcValu.ToString();
                    //break;
                case '-': return _num1 - _num2;
                    //calcValu = num1 - num2;
                    //CurrValu = calcValu.ToString();
                    //break;
                case '*': return _num1 * _num2;
                    //calcValu = num1 * num2;
                    //CurrValu = calcValu.ToString();
                    //break;
                case '/': return _num1 / _num2;
                    //calcValu = num1 / num2;
                    //CurrValu = calcValu.ToString();
                    //break;
                default: throw  new Exception("invalid calculation ");
                    //break;
            }
        }

        private void DoClear()
        {
            _currValu = "0";
            _num1 = 0;
            _num2 = 0;
            _operation = '0';
            _hasOperation = false;
            _startingSecondNumber = false;
        }

        private void DoOperator(char input)
        {
            _num1 = decimal.Parse(_currValu);
            _operation = input;
            _hasOperation = true;
        }

        private void DoEqualOperator()
        {
            _num2 = decimal.Parse(_currValu);
            _currValu = doCalculation().ToString();
            _isEqualSign = true;
            _hasOperation = false;
            _startingSecondNumber = false;
        }

        private void DoDigitsAndDecimal(char input)
        {
            if (_hasOperation & !_startingSecondNumber)
            {
                _startingSecondNumber = true;
                _currValu = "0";
            }

            if (_isEqualSign)
            {
                _isEqualSign = false;
                _currValu = "0";
            }

            if (input == '.' && _currValu.Contains("."))
            {
                // do nothing already has the decimal point
            }
            else
            {
                if (_currValu == "0")
                {
                    if (input == '.')
                    {
                        _currValu = _currValu + input;
                    }
                    else
                    {
                        _currValu = input.ToString();
                    }
                }
                else
                {
                    _currValu = _currValu + input;
                }
            }

        }
    }
}
