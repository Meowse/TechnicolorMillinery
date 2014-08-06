using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_1st_Part_HW4_EC
{
    public class Program
    {

        public string Puzzler(int arg1, int arg2, int arg3)
        {
            String result = "";
            if (arg1 < arg2)
            {
                arg2 = arg1;
                arg3 = arg2;
                result = "The value is " + arg2;
                if (arg3 < arg2)
                {
                    arg1 = arg2;
                    arg2 = arg3;
                    result = "The value is " + arg3;
                }
            }
            return result;
        }
    }
}

