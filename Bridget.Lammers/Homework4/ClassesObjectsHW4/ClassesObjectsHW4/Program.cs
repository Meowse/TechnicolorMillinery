using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsHW4
{
    class Program
    {
        static void Main(string[] args)
        {

            // HOMEWORK:
        // 1) Figure out what this method actually returns, and describe it, in detail, in terms of
        //      arg1 and arg2.
        // 2) Rewrite this method so that it does exactly the same thing, but doesn't have a single local
        //      variable whose scope is the entire method (like "OtherMethod", but, you know, with the
        //      same functionality as this method).
        //
        // EXTRA CREDIT:
        // 1) Write your own "puzzle" method.  Make it as confusing per length as you can.
        // 2) Share your "puzzle" method with the class (on the class forum), so that other people
        //    can try to figure out what it does, and how to rewrite it.
        // 3) Bring your solution to class on Tuesday (what it does, and what a clean rewrite looks like).
        public string SomeMethod(int arg1, int arg2)
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
        }
    }       
}
