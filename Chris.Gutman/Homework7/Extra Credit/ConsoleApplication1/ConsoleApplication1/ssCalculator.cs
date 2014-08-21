using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace ConsoleApplication1
{
    public class ssCalculator
    {
        private static Int64[] header = new Int64[5];

        private static void Main(string[] args)
        {

            const string matchstring = @"^(\d){1,7}$"; // at least one digit, nothing more. Limit to 7.
            var reoptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;
            var re = new Regex(matchstring);
            
            while (true)
            {
                Console.WriteLine("Please enter an integer (length<7) to convert to a spreadsheet column, or 'exit': \n");
                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    var rematch = re.Match(readLine);
                
                    if (rematch.Success)
                    { 
                        Int64 n = Convert.ToInt64(readLine);
                        string outputstring = getcolumn(n);
                        Console.WriteLine(outputstring);
                    }
                    else if (readLine == "exit")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("error, please try again (type any key to continue)");
                        Console.ReadKey();  
                    }
                }
            }
        }

        public static string getcolumn(Int64 n)
        {
            Int64[] larray = { 1, 26, 702, 18954, 511758 }; //26^4, 26^3, 26^2, 26^1, 26^0
            string temp = "";
            string[] names = new string[27]  //could also use ascii. let's do it this way this time...
            {
                "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
            string[] grandfinale = new string[4]
            {
                "A", "AA", "AAA", "AAAA"   
            };
            
            var i = 0;
            bool finished_f = false;
            bool firstpass = false;

            // Basic principle of operation: use modulo arithmatic. 
            //larray is used for the corresponding division (base 26).
            //the remainder is factored again in the next pass of the loop.
            //the quotient is used as an index into the names array to determine the column entries.
            //use int64 to simplify cast typing and for consistancy with methods available for readline.
            
            string mystring = "";
            for (i = 4; i >= 0; i--)
            {
                
                if (((Convert.ToInt64(larray[i]) <= n)))
                {
                    firstpass = true;
                    if ((i == 0)&& (finished_f == false))    //dont need to do division for the 26^0 case. Just set the output = remainder.
                    {
                        header[i] = n;
                        mystring = mystring + names[header[i]];
                    }
                    else 
                    { 
                        header[i] = (n-1) / (larray[i]);   // do the division and round to nearest.
                        n = (n - (header[i] * larray[i]));  // remainder

                        if ((n == 0 )&&(i!=0))//no remainder left
                        {
                            finished_f = true; //no remainder left. we're done early. signal loop through the rest...
                            temp = grandfinale[i-1];
                        }
                        else if ((i != 0) && (Convert.ToInt64(larray[i - 1]) > n))
                        {

    // In this case, we have run across a need to borrow from position i. Unfortunately, we aren't
    // borrowing from a prior  position, so if additional borrowing has to happen, 
    // it won't.....  uhggg, what a project!! I would like to up my original estimate from 
    // 1 point to 5 points!! This does, however, capture the max value case, 9999999, which is SN 'O' ZI.

                            header[i] = header[i] - 1;
                            header[i - 1] = 26;
                            mystring = mystring + names[header[i]] + names[header[i - 1]];
                            i = i - 1;
                        }
                        else
                        {
                            mystring = mystring + names[header[i]];
                        }
                    }
                    
                }
                else if ((finished_f == false) && (firstpass == false))
                {
                    header[i] = -1;
                   //prefix the output with something recognizable that can be removed when we concat the output string.
                }
            }

            mystring = mystring + temp;

            return mystring;
        }
    }
}
