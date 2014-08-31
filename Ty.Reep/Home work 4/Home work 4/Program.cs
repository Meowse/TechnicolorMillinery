using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_4
{
    public class ExampleClass
    {
        private static void Main(string[] args)
        {
            //int arg1 = 10; //17
            int arg2 = 32; //0

    
           
            //Console.WriteLine(SomeMethod(arg1, arg2));
            Console.ReadKey();
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
