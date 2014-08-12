namespace CalculatorBrain
{
    public class Calculator
    {
        private string _currentValue = "0";

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
            if (input == 'c')
            {
                _currentValue = "0";
            }
            else if (input == '.' && _currentValue.Contains("."))
            {
                // do nothing, because a second decimal is an invalid (ignored)
                // input
                //
                // _foo.Contains(bar) is basically syntactic sugar for
                // _foo.IndexOf(bar) > -1
            }
            else
            {
                // "the current value plus the input"
                // _currentValue + input
                // "put a value into _currentValue"
                // _currentValue = ...
                // "put the current value plus the input into the current value"
                // _currentValue = _currentValue + input;
                _currentValue = _currentValue + input;
            }
        }

        public string GetDisplay()
        {
            decimal currentValueAsNumber = decimal.Parse(_currentValue);
            return currentValueAsNumber.ToString();
        }
    }
}
