using System.Globalization;

namespace CalculatorBrain
{
    public class Calculator
    {
        private string CurrValu = "0";
        private decimal num1, num2, calcValu;
        private char operation;

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
            if (input == 'c' )
            {
                CurrValu = "0";
            }
            else if (input == '.' && CurrValu.Contains("."))
            {
                // do nothing already has the decimal point
            }
            else if (input == '+' || input == '-' || input == '*' || input == '/' )
            {
                num1 = decimal.Parse(CurrValu);
                operation = input;
//                CurrValu = "0";
            }
            else if (input == '=')
            {
                num2 = decimal.Parse(CurrValu);
                switch (operation)
                {
                    case '+':
                        calcValu = num1 + num2;
                        CurrValu = calcValu.ToString();
                        break;
                    case '-':
                        calcValu = num1 - num2;
                        CurrValu = calcValu.ToString();
                        break;
                    case '*':
                        calcValu = num1 * num2;
                        CurrValu = calcValu.ToString();
                        break;
                    case '/':
                        calcValu = num1 / num2;
                        CurrValu = calcValu.ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (CurrValu == "0")
                {
                    if (input == '.')
                    {
                        CurrValu = CurrValu + input;
                    }
                    else
                    {
                        CurrValu = input.ToString();
                    }
                }
                else
                {
                    CurrValu = CurrValu + input;
                }
            }
        }

        public string GetDisplay()
        {
            //return "0";
            NumberStyles style;
            style = NumberStyles.None;
            decimal CurrValuAsNumber;

            if (CurrValu.Contains("."))
            {
                return CurrValu;
            }
            CurrValuAsNumber = decimal.Parse(CurrValu, style );
            return CurrValuAsNumber.ToString();
        }
    }
}
