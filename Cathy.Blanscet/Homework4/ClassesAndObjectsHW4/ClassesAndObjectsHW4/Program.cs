using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsHW4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int arg1 = 10; //17
            int arg2 = 32; //0

            Console.WriteLine(SomeMethodReWrite(arg2));
            //Console.WriteLine(SomeMethod(arg1, arg2));
            Console.ReadKey();
        }

        // HOMEWORK:
        // 1) Figure out what this method actually returns, and describe it, in detail, in terms of
        //      arg1 and arg2.
        /* 
           //
           //ANSWER:
           //  It will return either a blank or Ooops. it doesn't matter what arg1 is, because arg2 is what 
           //    will set the string, and only if arg2 is greater than 6.
           //         
        */
        // 2) Rewrite this method so that it does exactly the same thing, but doesn't have a single local
        //      variable whose scope is the entire method (like "OtherMethod", but, you know, with the
        //      same functionality as this method).
        //
        public static string SomeMethodReWrite(int arg2)
        {
            if (("arg1" + arg2).Length > 5)
            {
                return "Ooops...";
            }
            else
            {
                return "";
            }
        }

        // EXTRA CREDIT:
        // 1) Write your own "puzzle" method.  Make it as confusing per length as you can.
        // 2) Share your "puzzle" method with the class (on the class forum), so that other people
        //    can try to figure out what it does, and how to rewrite it.
        // 3) Bring your solution to class on Tuesday (what it does, and what a clean rewrite looks like).
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

        public string OtherMethod(int arg1, int arg2)
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
