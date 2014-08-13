using System;
using System.Collections.Generic;
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
                CurrValu = CurrValu + input;
            }
        }

        public string GetDisplay()
        {
            //return "0";
            decimal CurrValuAsNumber = decimal.Parse(CurrValu);
            return CurrValuAsNumber.ToString();
        }
    }
}
