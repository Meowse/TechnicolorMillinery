using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace CalculatorBrain
{
    public class Calculator
    {
        private RegexOptions reoptions = new RegexOptions();
        public static string displayvalue = "0";

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
            const string mystring = @"(.+)?(\.)(.+)?";
            reoptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;
            Regex re = new Regex(mystring);
            Match rematch = re.Match(displayvalue);
            if ((rematch.Success) & (input == '.'))
            {

            }
            else
            {
                displayvalue = displayvalue + input.ToString();
            }

        }

        public string GetDisplay()
        {
            return displayvalue;
        }
    }
}
