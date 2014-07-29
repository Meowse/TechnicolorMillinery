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

       public string SomeMethod2(int arg1, int arg2)  //refactored
        {
            if (arg2 > 6 && arg2 < 10)
            {
                return "arg1" + arg2;
            }
            else if (arg2 > 10)
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
