namespace CalculatorBrain
{
    public class Calculator
    {
        private string _currentValue = "";
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
        public void ProvideInput(string input)
        {
            switch (input)
            {
                case "c":
                    _currentValue = "0";
                    break;
                case ".":
                    _currentValue = ".";
                    break;
                case "1":
                    _currentValue = "1";
                    break;
                case "2":
                    _currentValue = "2";
                    break;
                case "3":
                    _currentValue = "3";
                    break;
                case "4":
                    _currentValue = "4";
                    break;
                case "5":
                    _currentValue = "5";
                    break;
                case "6":
                    _currentValue = "6";
                    break;
                case "7":
                    _currentValue = "7";
                    break;
                case "8":
                    _currentValue = "8";
                    break;
                case "9":
                    _currentValue = "9";
                    break;

                default:
                    break;
            }
        }

        public string GetDisplay()
        {
            decimal currentValueAsNumber = decimal.Parse(_currentValue);
            return currentValueAsNumber.ToString();
        }

    }
}
