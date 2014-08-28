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

            Int64[] larray = {1, 27, 703, 18955, 511759}; //A Z ZZ ZZZ ZZZZ
            Int64[] larray2 = {1, 26, 676, 17576, 456976}; // 20^0 26^1 26^2 26^3 26^4
            string temp = "";
            var names = new string[27] //could also use ascii. Decided to do it this way...
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
            var k = 0;
            var k1 = 0;
            var finished_f = false;
            var donotaddfirst = false;
            var firstpass = true;
            string mystring = "";
            Int64 inputvar = n;

/* This for  loop performs successive divsions based on Z, ZZ, ZZZ, and so on (i.e. larray[]).  There are 27 Z's, ZZ's, 
 * before the shift from Z to AA, ZZ to AAA, etc.  Hence the coefficient, Ci in Ci*larray[i], where
 * program input = sum over i(i=0 to 4) of {Ci*larray[i]} plus 1.

/* This is a bit of a tricky one. When the remainder is less than the power of 26 we are dividing by, 
 */
            for (k = 4; k > 0; k--)
            {
                if (Convert.ToInt64(larray[k])<=n)
                {
                    n = n - larray[k];
                    break;
                }
            }
            k1 = k;
            if ((Convert.ToInt64(larray2[k]) <= n)&&(k!=0))
            {
                for (k = 4; k > 0; k--)
                {
                    //if (n == larray2[k])
                    //{
                    //    return "A" + finale[k - 1];
                    //}

                    if (Convert.ToInt64(larray2[k]) <= n)
                    {
                        break;
                    }
                }
            }
            if (k1!=k)
            {
                donotaddfirst = true;
            }
            for (i=k; i >= 0; i--)
            {                
                if (((Convert.ToInt64(larray2[i]) <= n)&&finished_f==false))
                {
                    if (i == 0)    //dont need to do division for the 26^0 case. Just set the output = remainder.
                    {
                        header[i] = (firstpass == true)?   n : n + 1; 
                        finished_f = true;
                        mystring = mystring + names[header[i]];
                        
                    }
                    else 
                    {
                        // normal case: do the division and round to nearest.

                        header[i] = n/larray2[i];
                        n = (n - (header[i] * larray2[i]));
                        if (donotaddfirst == false)
                        {
                            header[i] = header[i] + 1;
                        }
                        
                        //if there is no remainder left, we're finished and just append the rest with whats in finale[]

                        if (n == 0)
                        {
                            finished_f = true;
                            temp = finale[i - 1];
                        }
                        mystring = mystring + names[header[i]];    
                        
                        // otherwise, the normal situation is to append the string using names[]
                    }
                    
                }
                else if ((Convert.ToInt64(larray2[i]) > n)&&(finished_f == false)&&(n!=0))
                {
                    header[i] = 1;
                    mystring = mystring + names[header[i]];
                }
                else if ((n == 0)&&(finished_f == false))
                {
                    finished_f = true;
                    header[i] = n/larray2[i] + 1;
                    temp = finale[i-1];
                    mystring = mystring + names[header[i]];
                }
                firstpass = false;
            }

            mystring = mystring + temp;

            return mystring;
        }
    }
}
