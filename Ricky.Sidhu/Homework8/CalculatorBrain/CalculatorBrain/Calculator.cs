using System.Globalization;
using System.Runtime.Serialization.Formatters;

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

            }

           else
            {
                _currentValue = _currentValue + input;
            }

            }
  
        public string GetDisplay()
        {
            if (_currentValue.Contains("."))
            {
                return _currentValue;
            }
            var currentValueAsNumber = decimal.Parse(_currentValue);
            return currentValueAsNumber.ToString(CultureInfo.CurrentCulture);
        }
        
    }
}
