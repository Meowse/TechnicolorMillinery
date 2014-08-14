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

        private static void Main(string[] args)
        {
            Int64[] larray = {456976, 17576, 676, 26, 1}; //26^4, 26^3, 26^2, 26^1, 26^0
            Int64[] header = new Int64[5];
            string[] names = new string[27]
            {
                "","A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
            string mystring;
            var J = 0;
            var i = 0;

// Basic principle of operation: use modulo arithmatic. 
            //larray is used for the corresponding division (base 26).
            //the remainder is factored again in the next pass of the loop.
            //the quotient is used as an index into the names array to determine the column entries.
            //use int64 to simplify cast typing and for consistancy with methods available for readline.
            //i = 10 forces exit from the  loop.
            //second and thrid if loops remove A's prefixed to the result.

            while (true)
            {
                Console.WriteLine("Please enter an integer to convert to a spreadsheet column: \n ");
                Int64 n = Convert.ToInt64(Console.ReadLine());

                for ( i = 0; i <= 4; i++)
                {
                    if ((Convert.ToInt64(larray[i])) <= n)
                    {
                        header[i] = n/larray[i];
                        n = (n - header[i]*(larray[i]));
                    }
                    else
                    {
                        header[i] = 0;
                    }
                }

                for(i = 0;i<=4;i++)
                {
                    if (header[i] != 0)
                    {
                        J = i;
                        i = 10;
                    }
                }

                mystring = "";
                for (i = J; i<=4; i++)
                {
                    mystring = mystring + names[header[i]];
                }

                Console.WriteLine(header[0] + " ," + header[1] + " ," + header[2] + " ," + header[3] + " ," + header[4]);
                Console.WriteLine(mystring);

            }
        } 
    }
}
