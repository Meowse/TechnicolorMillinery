using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Drawing;

namespace CalculatorBrain
{
    public class Calculator
    {

        //private string _operation = "";
        private string _currentValue = "";
        private decimal _NumberOne, _NumberTwo = 0;
        private char _operator;

        public bool HasDecimal = false;
        private bool EnteringFirstNumber = true;
        private bool HasOperator = true;

        public List<char> ValuesList = new List<char>();
        private readonly List<char> operatorsList = new List<char> {'+', '-', '/', '*'};
        private readonly List<char> digitOrDecimaList = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };

        public void ProcessInput(char input)
        {
            ValuesList.Add(input);
            // if currentvalue is empty then Enteringfirstnumber == true
            // if currentvalue is occupied then EnteringFirstNumber == false
            // if EnteringFirstNumber == false then _storevalue == _currentvalue
            // if char == '+' || '-', etc.. && HasOperator == true then
            // _sumValue = _currentvalue (operator) _storevalue
            // _storevalue = sumValue
            // GetDisplay(sumValue)
            if (input == 'c')
            {
                ProcessClear();
            }
            else if (IsOperator(input))
            {
                ProcessOperator(input);
            }
            else if (input == '=')
            {
                ProcessEquals();
            }
            else if (IsDigitOrDecimal(input))
            {
                ProcessDigitOrDecimal(input);
            }
            else
            {
                ProcessError(input);
            }
        }
        private decimal Calculate()
        {
            switch (_operator)
            {
                case '+':
                    return _NumberOne + _NumberTwo;
                    break;
                case '-':
                    return _NumberOne - _NumberTwo;
                    break;
                case '*':
                    return _NumberOne*_NumberTwo;
                    break;
                case '/':
                    return _NumberOne/_NumberTwo;
                default: throw new Exception("Invalid Operator " + _operator);
            }
        }

        private void ProcessError(char input)
        {
            throw new NotImplementedException();
        }

        private void ProcessEquals()
        {
            _NumberTwo = decimal.Parse(_currentValue);
            _currentValue = Calculate().ToString();
        }

        
        private void ProcessClear()
        {
            _currentValue = "0";
        }

        private void ProcessDigitOrDecimal(char input)
        {

        }

        private void ProcessOperator(char input)
        {
            _NumberOne = decimal.Parse(_currentValue);
            _operation = inputOperator;
            HasOperator = true;
        }

        private bool IsOperator(char input)
        {
            return operatorsList.Contains(input);
        }

        private bool IsDigitOrDecimal(char input)
        {
            return digitOrDecimaList.Contains(input);
        }

        

        public string GetDisplay()
        {
            if (_currentValue != null)
            {
                if (EnteringFirstNumber)
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
