using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        // 2) Rewrite this method so that it does exactly the same thing, but doesn't have a single local
        //      variable whose scope is the entire method (like "OtherMethod", but, you know, with the
        //      same functionality as this method).
        public string Method(int arg1, int arg2)
        {
            if (arg2 <= 6) return "";
            else if (arg2 <= 9) return "arg1" + arg2;
            else return "Ooops...";
        }

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






