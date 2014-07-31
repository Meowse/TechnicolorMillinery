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
            if (arg1 < 17) // arg1 must < 17
            {
                if (arg2 > 12)  //you will never see where arg2 < 13 here
                {               // 13 through 22 only
                    result = "Fred!";
                }
                if (arg2 > 22)  // 23 +
                {
                    result = "I hate logic!";
                }
            }

            //below supersedes all of the code above since it sets result due to arg2 > 6

            if (arg2 > 6) 
            {
                result = "arg1" + arg2;  //if arg2= 7, 8, 9 result = "arg17", "arg18", "arg19"
                if (result.Length > 5) 
                {
                    result = "Ooops..."; // if arg2 is 10 or greater result = "Ooops..."
                }
            }
            return result;
        }


        public string OtherMethod(int arg1, int arg2)  //Homework 2 - refactor
        {
            /* this code is not needed since the code below sets result and overwrites this variable results
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
             */

            if (arg2 > 6)
            {
                String result = "arg1" + arg2; //why don't I need arg2.ToString() ?<- redundent?
                //result = "arg17", "arg18" ..."arg1999999999" '999999999' represents as big as int can handle

                if (result.Length > 5)
                {
                    return "Ooops...";
                }
                
                return result;
            
            }
           
        }

    }
}
