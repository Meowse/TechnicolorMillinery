using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace CalculatorBrain
{
    public class Calculator
    {
        private  string CurrValu = "0";

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
                CurrValu = "0";
            }
            else if (input == '.' && CurrValu.Contains("."))
            {
                // do nothing already has the decimal point
            }
            else
            {
                if (CurrValu == "0")
                {
                    CurrValu = input.ToString();
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
