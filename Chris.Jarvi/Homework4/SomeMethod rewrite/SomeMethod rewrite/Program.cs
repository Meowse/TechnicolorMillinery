using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeMethod_rewrite
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string SomeMethod(int arg1, int arg2) //original 
        {
            String result = "";
            if (arg1 < 17)
            {
                if (arg2 > 12)
                {
                    result = "Fred!";
                }
                if (arg2 > 22)
                {
                    result = "I hate logic!";
                }
            }
            if (arg2 > 6)
            {
                result = "arg1" + arg2;
                if (result.Length > 5)
                {
                    result = "Ooops...";
                }
            }
            return result;
        }

        /*  For this puzzle it doesn't matter what arg1's value is.  It's all dependent upon arg2.
         * if arg2 is between 6 and 10, it'll print the string "arg1" plus the string representation of arg2.
         * if arg2 is greater or equal to 10, it'll print "Ooops..." because the length of the concatenated string of 
         * "arg1" plus the string representation of arg2 will always be greater than 5 characters.
         */

       public string SomeMethod2(int arg1, int arg2)  //refactored
        {
            if (arg2 > 6 && arg2 < 10)
            {
                return "arg1" + arg2;
            }
            else if (arg2 >= 10)
            {
                return "Ooops...";
            }
            else
            {
                return "";
            }
        }
    }
}
