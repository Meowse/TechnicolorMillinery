using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static Int64[] header = new Int64[5];

        private static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Please enter an integer to convert to a spreadsheet column: \n");
                Int64 n = Convert.ToInt64(Console.ReadLine());

                string outputstring = getcolumn(n);

                Console.WriteLine(header[4] + " ," + header[3] + " ," + header[2] + " ," + header[1] + " ," + header[0]);
                Console.WriteLine(outputstring);

            }
        }

        public static string getcolumn(Int64 n)
        {
            Int64[] larray = { 1, 26, 676, 17576, 456976 }; //26^4, 26^3, 26^2, 26^1, 26^0

            string[] names = new string[27]
            {
                "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
            string mystring;
            var J = 0;
            var i = 0;
            bool finished_f = false;

            // Basic principle of operation: use modulo arithmatic. 
            //larray is used for the corresponding division (base 26).
            //the remainder is factored again in the next pass of the loop.
            //the quotient is used as an index into the names array to determine the column entries.
            //use int64 to simplify cast typing and for consistancy with methods available for readline.

            for (i = 4; i >= 0; i--)
            {
                
                if ((Convert.ToInt64(larray[i])) <= n)
                {
                    header[i] = (n-1) / (larray[i]);
                    n = (n - (header[i]) * (larray[i]));
                    if (n == 0)
                    {
                        finished_f = true;
                    }
                }
                else if (finished_f == true) //((Convert.ToInt64(larray[i])) == n)
                {
                    header[i] = larray[i];
                    n = 0;
                    //finished_f = true;
                }
                else
                {
                    header[i] = -1;
                }
            }

            mystring = "";

            for (i = 4; i >= 0; i--)
            {
                if (header[i] != -1)
                {
                    mystring = mystring + names[header[i]];
                }

            }
            return mystring;
        }
    }
}
