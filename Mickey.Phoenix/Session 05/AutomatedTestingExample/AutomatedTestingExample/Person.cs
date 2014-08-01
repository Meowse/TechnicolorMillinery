using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestingExample
{
    public class Person
    {
        // The value of "arg1" is ignored.
        // If arg2 is less than 7, it will return "".
        // If arg2 is 7, 8, or 9, I will return "arg17", "arg18", or "arg19"
        // If arg2 is 10 or greater, it will return "Ooops..."
        public string SomeMethod(int arg1, int arg2)
        {
            String result = "";
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

        // The value of "arg1" is ignored.
        // If arg2 is less than 7, it will return "".
        // If arg2 is 7, 8, or 9, I will return "arg17", "arg18", or "arg19"
        // If arg2 is 10 or greater, it will return "Ooops..."
        public string SomeMethodRefactored(int arg)
        {
            if (arg <= 6)
            {
                return "";
            }

            string result = "arg1" + arg;
            if (result.Length > 5)
            {
                return "Ooops...";
            }
            return result;
        }


        public int SquareIt(int i)
        {
            return i*i;
        }
    }
}
