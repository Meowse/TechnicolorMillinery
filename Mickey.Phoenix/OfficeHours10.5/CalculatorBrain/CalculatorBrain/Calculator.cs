using System;
using System.Collections.Generic;

namespace CalculatorBrain
{
    public class Calculator
    {
        private readonly Stack<PendingOperation> _pendingOperations = new Stack<PendingOperation>();

        private decimal _accumulatedValue;
        private string _currentValue;
        private Operator _operator;

        public Calculator()
        {
            Clear();
        }

        public void ProvideInput(char input)
        {
            switch (input)
            {
                case 'c':
                    Clear();
                    break;
                case '(':
                    StartSubExpression();
                    break;
                case ')':
                    EndSubExpression();
                    break;
                case '+':
                    ProcessOperator(Operator.Addition);
                    break;
                case '-':
                    ProcessOperator(Operator.Subtraction);
                    break;
                case '*':
                    ProcessOperator(Operator.Multiplication);
                    break;
                case '/':
                    ProcessOperator(Operator.Division);
                    break;
                case '=':
                    PerformCalculation();
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '.':
                    ProcessNumber(input);
                    break;
            }
        }

        private void StartSubExpression()
        {
            _pendingOperations.Push(new PendingOperation
            {
                AccumulatedValue = _accumulatedValue,
                Operator = _operator
            });
            _accumulatedValue = 0;
            _operator = Operator.None;
            _currentValue = null;
        }

        private void EndSubExpression()
        {
            if (_pendingOperations.Count == 0)
            {
                return; // ignore mismatched parentheses
            }

            // Do the calculation "inside the parentheses".  This will put the result
            // of the parenthesized calculation into _accumulatedValue.
            PerformCalculation();

            // Move the result of that calculation into _currentValue, so that we can
            // pop the stored value from _pendingOperations into the _accumulatedValue.
            _currentValue = _accumulatedValue.ToString();

            // Pop the stored value and operator from the top of _pendingOperations
            // and put it into _accumulatedValue and _operator.
            PendingOperation pending = _pendingOperations.Pop();
            _accumulatedValue = pending.AccumulatedValue;
            _operator = pending.Operator;
        }

        private void Clear()
        {
            _accumulatedValue = 0;
            _operator = Operator.None;
            _currentValue = null;
        }

        private void ProcessOperator(Operator newOperator)
        {
            PerformCalculation();
            _currentValue = null;
            _operator = newOperator;
        }

        private void ProcessNumber(char input)
        {
            if (input == '.' && _currentValue != null && _currentValue.Contains("."))
            {
                return;
            }

            _currentValue += input;
        }

        public string GetDisplay()
        {
            if (_currentValue == null)
            {
                return _accumulatedValue.ToString();
            }
            if (_currentValue == ".")
            {
                return "0.";
            }
            var display = decimal.Parse(_currentValue).ToString();
            if (_currentValue.EndsWith("."))
            {
                display += ".";
            }
            return display;
        }

        public void PerformCalculation()
        {
            switch (_operator)
            {
                case Operator.None:
                    _accumulatedValue = Convert.ToDecimal(_currentValue);
                    break;

                case Operator.Addition:
                    _accumulatedValue = _accumulatedValue + Convert.ToDecimal(_currentValue);
                    break;

                case Operator.Subtraction:
                    _accumulatedValue = _accumulatedValue - Convert.ToDecimal(_currentValue);
                    break;

                case Operator.Multiplication:
                    _accumulatedValue = _accumulatedValue * Convert.ToDecimal(_currentValue);
                    break;

                case Operator.Division:
                    _accumulatedValue = _accumulatedValue / Convert.ToDecimal(_currentValue);
                    break;
            }
            _currentValue = null;
        }
    }
}
