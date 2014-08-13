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
        public static decimal savednumber = 0;
        private static string internal_state = "waiting";

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

// Use a regular expression to recognize when a '.' has already been placed inside the string

            string mystring = @"(.+)?(\.)(.+)?";
            reoptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;
            Regex re = new Regex(mystring);
            Match rematch = re.Match(displayvalue);

// 

            if ((rematch.Success) & (input == '.'))
            {

            }
            else if (input == '+')
            {
                internal_state = "add";
                savednumber = Convert.ToDecimal(displayvalue);
                displayvalue = displayvalue + input;
            }
            else if (input == '-')
            {
                internal_state = "subtract";
                savednumber = Convert.ToDecimal(displayvalue);
                displayvalue = displayvalue + input;

            }
            else if (input == '*')
            {
                internal_state = "multiply";
                savednumber = Convert.ToDecimal(displayvalue);
                displayvalue = displayvalue + input;

            }
            else if (input == '/')
            {
                internal_state = "divide";
                savednumber = Convert.ToDecimal(displayvalue);
                displayvalue = displayvalue + input;

            }
            else if (input == 'c')
            {
                displayvalue = "0";
                internal_state = "waiting";
            }
            else if((internal_state == "waiting")&& (displayvalue != "0"))
            {

                displayvalue = displayvalue + input.ToString();
            }
            else if(internal_state == "waiting")
            {
                displayvalue = input.ToString();
            }
            else if (internal_state == "add")
            {
                savednumber = savednumber + Convert.ToDecimal(input.ToString());
                displayvalue = savednumber.ToString();
            }
            else if (internal_state == "subtract")
            {
                savednumber = savednumber - Convert.ToDecimal(input.ToString());
                displayvalue = savednumber.ToString();

            }
            else if (internal_state == "multiply")
            {
                savednumber = savednumber * Convert.ToDecimal(input.ToString());
                displayvalue = savednumber.ToString();

            }
            else if ((internal_state == "divide") && (Convert.ToDecimal(input.ToString()) != 0))
            {
                savednumber = savednumber / Convert.ToDecimal(input.ToString());
                displayvalue = savednumber.ToString();

            }
            {
                
            }

        }

        public string GetDisplay()
        {
            return displayvalue;
        }
    }
}
