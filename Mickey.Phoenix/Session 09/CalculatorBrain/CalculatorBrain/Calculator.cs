using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculatorBrain
{
    // The basic model of this implementation of Calculator is:
    // "_currentValue is whatever is on the screen, and when the user
    // provides input, we change _currentValue so that it displays whatever
    // should be on the screen".
    //
    // The down-side of this model is that it ties the representation of the
    // calculator's internal state *too closely* to the data on the screen.
    // And what makes for a good "state of the screen" may not be anything like
    // what makes for a good "internal state of the calculator representation".
    //
    // An alternative model would be to start by thinking, "What does the
    // calculator's internal state look like?" and then asking the question,
    // "Given the calculator's internal state, how do we decide what to display
    // on the screen?"
    //
    // This will lead to a model for the calculator's internal state that is
    // driven by what the calculator needs in order to do its calculations, and
    // to a cleaner separation between "what the calculator knows" and "what we
    // show to the user".

    // The model we get if we start with "what a calculator knows" is that we have
    // an "accumulator" value that holds the results of the calculation so far
    // (which starts out as 0), a "current operation" value which may or may not
    // exist, and a "current value being entered by the user" value which holds
    // the number the user is currently entering.

    // With this model, we would keep "_accumulator", a decimal value that starts
    // as 0, and holds the results of the calculation so far.
    // We would keep "_operation", which starts as (char)0 and holds the operation
    // entered by the user.
    // We would keep "_currentNumber", a decimal value which starts as null, and
    // holds the numeric value the user has entered so far.
    // We would keep "_currentNumberHasDecimal", a boolean value which starts as
    // false, and is set to true if the user enters a decimal point in the current
    // number.

    // Suggestion: Once you get your calculator working to this point, handling
    // multiple sequential operations like 1+1=2 2+2=4:
    // 1) Make a copy of your calculator solution.
    // 2) In the copy, re-implement Calculator according to the above model, but
    //      keeping the tests and interface stuff the same.
    // 3) Once you have the copy working (all tests passing):
    //      a) In your new implementation, add a test for 1+2+4=7, and note how
    //          hard it is (or isn't).
    //      b) In your original implementation (this one), add the same test for
    //          1+2+4=7, and note how (much) hard(er) it is.

    // Food for thought: once you've done (3.b) above, you will probably have a
    // solution that looks a lot like the "accumulator" solution, except that
    // the accumulator will be named, maybe, "_num1", for example.  And you can
    // always get to a good design by continuing to work on a bad model, and 
    // periodically stopping and refactoring when the names "drift" too far from
    // their original meanings.
    //
    // But that feeling of "this is getting too complicated, and I'm holding too
    // much stuff in my head" -- if you listen to that feeling, and respond to it
    // by doing a re-design that incorporates everything you've learned working
    // on the first implementation -- can save you a HUGE amount of pain and
    // struggle in that process.
    public class Calculator
    {
        private string _currentValue = "0";
        private decimal _num1, _num2;
        private char _operation;

        // State variables for the internal calculator state
        private bool _hasOperation;
        private bool _isEnteringSecondNumber;
        private bool _hasEquals;

        private readonly List<char> _operations = new List<char>
        {
            '/', '*', '-', '+'
        };

        private readonly List<char> _digitOrDecimal = new List<char>
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.'
        };

        public Calculator()
        {
            ProcessClear();
        }

        // The current state of the calculator will have to be stored somehow
        // in instance variables, here, declared directly inside the "Calculator"
        // scope.

        // States of the calculator:
        // 1) The user hasn't entered anything: display "0"
        // 2) The user is entering the first number: 
        //      (hasOperation = false, isEnteringSecondNumber = false)
        //      display that (first) number
        // 3) The user has entered an operator:
        //      (hasOperation = true, isEnteringSecondNumber = false)
        //      display that (first) number
        // 4) The user is entering the second number:
        //      (hasOperation = true, isEnteringSecondNumber = true)
        //      display that (second) number


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
        public void ProcessInput(char input)
        {
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
                throw new Exception("Invalid input " + input);
            }
        }

        private bool IsDigitOrDecimal(char input)
        {
            return _digitOrDecimal.Contains(input);
        }

        private bool IsOperator(char input)
        {
            return _operations.Contains(input);
        }

        private void ProcessClear()
        {
            _currentValue = "0";
            _num1 = 0;
            _num2 = 0;
            _operation = (char) 0;
            _hasOperation = false;
            _isEnteringSecondNumber = false;
        }

        private void ProcessOperator(char inputOperator)
        {
            _num1 = decimal.Parse(_currentValue);
            _operation = inputOperator;
            _hasOperation = true;
        }

        private void ProcessEquals()
        {
            _num2 = decimal.Parse(_currentValue);
            _currentValue = Calculate().ToString();
            _hasEquals = true;
            _hasOperation = false;
            _isEnteringSecondNumber = false;
        }

        private void ProcessDigitOrDecimal(char input)
        {
            // When we go from "not yet entering a second number" to
            // "entering a second number", we need to clear out _currentValue
            // and start adding the digits to it from scratch.
            if (_hasOperation && !_isEnteringSecondNumber)
            {
                _isEnteringSecondNumber = true;
                _currentValue = "0";
            }

            // When we go from "has equals" to "entering the first number of a 
            // new equation", we need to clear out _currentValue and start adding
            // the digits to it from scratch.
            if (_hasEquals)
            {
                _hasEquals = false;
                _currentValue = "0";
            }

            if (input == '.' && _currentValue.Contains("."))
            {
                // do nothing already has the decimal point
            }
            else
            {
                if (_currentValue == "0")
                {
                    if (input == '.')
                    {
                        _currentValue = _currentValue + input;
                    }
                    else
                    {
                        _currentValue = input.ToString();
                    }
                }
                else
                {
                    _currentValue = _currentValue + input;
                }
            }
        }

        private decimal Calculate()
        {
            switch (_operation)
            {
                case '+': return _num1 + _num2;
                case '-': return _num1 - _num2;
                case '*': return _num1 * _num2;
                case '/': return _num1 / _num2;
                default: throw new Exception("Invalid operator " + _operation);
            }
        }

        public string GetDisplay()
        {
            if (_currentValue.Contains("."))
            {
                return _currentValue;
            }

            var currValuAsNumber = decimal.Parse(_currentValue, NumberStyles.None);
            return currValuAsNumber.ToString();
        }
    }
}
