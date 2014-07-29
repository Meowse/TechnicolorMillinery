using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SomeMethod(2, 8));
            Console.ReadKey();
        }

        public static string SomeMethod(int arg1, int arg2)
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


        public static string OtherMethod(int arg1, int arg2)
        {
            if (arg1 < 17)
            {
                if (arg2 > 12)
                {
                    return "Fred!";
                }
                if (arg2 > 22)
                {
                    return "I hate logic!";
                }
                return "";
            }
            if (arg2 > 6)
            {
                String result = "arg1" + arg2;
                if (result.Length > 5)
                {
                    return "Ooops...";
                }
                return result;
            }
            return "";
        }
    }
}

// HOMEWORK:
// 1) Figure out what this method actually returns, and describe it, in detail, in terms of
//      arg1 and arg2.

    // Answers: the returns will depend on the number of arg2, no matter what arg1 is.
   /*   arg2		returns
     	(-∞, 6]		""
		(6, 9]		"arg1x"
		(9, +∞)		"Ooops..."*/





