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

// Arrays needed

            Int64[] larray = { 1, 26, 702, 18954, 511758 }; //1 Z ZZ ZZZ ZZZZ
            string temp = "";
            var names = new string[27]  //could also use ascii. Decided to do it this way...
            {
                "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
            var finale = new string[4]
            {
                "A", "AA", "AAA", "AAAA"   
            };

// Initializations            

            var i = 0;
            var finished_f = false;
            var firstpass = false;
            string mystring = "";

// This for  loop performs successive divsions by based on 26.

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
                        // normal case: do the division and round to nearest.

                        header[i] = (n-1) / (larray[i]);

                        // remainder

                        n = (n - (header[i] * larray[i])); 

                        //if there is no remainder left, we're finished and just append the rest with whats in finale[]

                        if ((n == 0) && (i != 0))
                        {
                            finished_f = true; 
                            temp = finale[i-1];
                        }

                        // otherwise, the normal situation is to append the string using names[]

                        else
                        {
                            mystring = mystring + names[header[i]];
                        }
                    }

                }

// the minimum a digit can take is A, or one. There is no zero. If the remainder is less than the divisor, the required digit is Z

                else if ((Convert.ToInt64(larray[i]) > n)&& (i>=1)&&(firstpass == true)&&(n!=0))
                {
                    mystring = mystring + names[26];

                }


// Here, we prepend the output with something recognizable that can be removed when we concat the output string.

                else if ((finished_f == false) && (firstpass == false))
                {
                    header[i] = -1;
                   //
                }
            }

            mystring = mystring + temp;

            return mystring;
        }
    }
}
