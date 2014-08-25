using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndImprovingCode
{
    public class ExampleClass
    {


        public string SomeOtherMethod(int arg1, int arg2)
        {
            String result = "";
            if (arg2 < 6)
            {
                return result;
            }
            else
            {
                result = "arg1" + arg2;
            }
            if (result.Length > 5)
            {
                result = "Ooops...";
            }
            return result;
        }
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
