using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4args
{
    class Program
    {
    static void Main(string[] args);
        
    public class Person
    {
        public static int NextSocialSecurityNumber = 987654321;

        public Person Spouse;

        public int SSN;

        public string FirstName;
        public string LastName;

        public Person()
        {
            SSN = NextSocialSecurityNumber;
            NextSocialSecurityNumber = NextSocialSecurityNumber + 1;
        }

        public void Rename(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // HOMEWORK:
        // 1) Figure out what this method actually returns, and describe it, in detail, in terms of
        //      arg1 and arg2.
        // 2) Rewrite this method so that it does exactly the same thing, but doesn't have a single local
        //      variable whose scope is the entire method (like "OtherMethod", but, you know, with the
        //      same functionality as this method).
        //
        //ANSWERS FOR 1:
        // Arg 2 is dependend in the number with returns. Arg1 is not significant other than being less than 17.
        // If arg2= 7,8,9, result = "arg17", "arg"18", "arg 19". if arg 2 is 10 or greater result ="oops"


        // EXTRA CREDIT:
        // 1) Write your own "puzzle" method.  Make it as confusing per length as you can.
        // 2) Share your "puzzle" method with the class (on the class forum), so that other people
        //    can try to figure out what it does, and how to rewrite it.
        // 3) Bring your solution to class on Tuesday (what it does, and what a clean rewrite looks like).
        public string SomewhatrefactoredMethod(int arg1, int arg2) 
        {
                if (arg2 <=6)
                {
                    return "";
                }
          
                else if (result.Length > 5
                {
                    result = "Ooops...";
                }
            }
            result;
        }

        public string OtherMethod(int arg1, int arg2)
        {
            if (arg1 < 17)
            {
                if (arg2 > 12)
                {
                    return "Fred!";
                }
                if (arg2 > 22)
                {
                    return "I hate logic!";
                }
                return "";
            }
            if (arg2 > 6)
            {
                String result = "arg1" + arg2;
                if (result.Length > 5)
                {
                    return "Ooops...";
                }
                return result;
            }
            return "";
          
            
            
        }

        }

    }
}
 