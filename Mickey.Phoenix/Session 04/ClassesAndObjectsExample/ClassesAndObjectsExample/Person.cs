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
        // EXTRA CREDIT:
        // 1) Write your own "puzzle" method.  Make it as confusing per length as you can.
        // 2) Share your "puzzle" method with the class (on the class forum), so that other people
        //    can try to figure out what it does, and how to rewrite it.
        // 3) Bring your solution to class on Tuesday (what it does, and what a clean rewrite looks like).


        // The value of "arg1" is ignored.
        // If arg2 is less than 7, it will return "".
        // If arg2 is 7, 8, or 9, I will return "arg17", "arg18", or "arg19"
        // If arg2 is 10 or greater, it will return "Ooops..."
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

        // The value of "arg1" is ignored.
        // If arg2 is less than 7, it will return "".
        // If arg2 is 7, 8, or 9, I will return "arg17", "arg18", or "arg19"
        // If arg2 is 10 or greater, it will return "Ooops..."
        public string SomeMethodRefactored(int arg)
        {
            if (arg <= 6)
            {
                return "";
            }

            string result = "arg1" + arg;
            if (result.Length > 5)
            {
                return "Ooops...";
            }
            return result;
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
