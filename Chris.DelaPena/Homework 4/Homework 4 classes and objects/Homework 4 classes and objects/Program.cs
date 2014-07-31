using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_classes_and_objects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        //1) Figure out what this method returns, and describe it, in detail, in terms of arg1 and arg2.
        //If arg2 is less than or equal to 6, assign "" to result. If arg2 is greater than 6 and less than or equal to 9, assign "arg1x" to result. If arg2 is greater than 9, assign "Oooops!" to result.

        public string rewriteMethod(int arg1, int arg2)
        {
            String result;
            int arg2;

            if (arg2 <= 6)
            {
                result = "";
            }
            if (6 < arg2 <= 9)
            {
                result = "arg1" + arg2;
            }
            if (arg2 > 9)
            {
                result = "Oooops!";
                {
                    return result;
                }
            }
        }
    }
}