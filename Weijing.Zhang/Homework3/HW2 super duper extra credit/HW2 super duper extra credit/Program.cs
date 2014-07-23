using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_super_duper_extra_credit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input your score(0-100"); 

            string x = Console .ReadLine (); 

            int  y = int.Parse (x);  

            if (y < 0 || y > 100)
            { Console.WriteLine("Errer input"); 
                return; }

            if (y >= 90) Console.WriteLine("Excellent!");

            else if (y >= 80) Console.WriteLine("good");

            else if (y >= 60) Console.WriteLine("Fair");

            else Console.WriteLine("Bad");
            Console.ReadKey();
        }
    }
}
