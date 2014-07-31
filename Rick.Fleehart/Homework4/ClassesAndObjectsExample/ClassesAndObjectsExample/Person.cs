using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndObjectsExample
{
    public class Person
    {
        public static int NextSocialSecurityNumber = 987654321;

        public Person Spouse;

        public int Ssn;

        public string FirstName;
        public string LastName;

        public Person()
        {
            Ssn = NextSocialSecurityNumber;
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
        // EXTRA CREDIT:
        // 1) Write your own "puzzle" method.  Make it as confusing per length as you can.
        // 2) Share your "puzzle" method with the class (on the class forum), so that other people
        //    can try to figure out what it does, and how to rewrite it.
        // 3) Bring your solution to class on Tuesday (what it does, and what a clean rewrite looks like).
        public string SomeMethod(int arg1, int arg2) //Homework 1
        {
            String result = "";
            if (arg1 < 17) // arg1 must be 16, 15,14,13 only then result = "Fred!"
            {
                if (arg2 > 12) 
                {
                    result = "Fred!";
                }
                if (arg2 > 22) //this is never happen because arg1 must be < 17
                {
                    result = "I hate logic!";
                }
            }
            if (arg2 > 6) //if arg2= 7 thru 9 result = "arg17", "arg18", "arg19"
            {
                result = "arg1" + arg2;
                if (result.Length > 5) 
                {
                    result = "Ooops..."; // if arg2 is 10 or greater result = "Ooops..."
                }
            }
            return result;
        }

        public string OtherMethod(int arg1, int arg2)  //Homework 2
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
