﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5_7_Sopcak
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


        public string SomeMethod(int arg1, int arg2)
        {
            String result = "";
            if (arg1 < 17)
            {
                if (arg2 > 12)
                {
                    result = "Happy";
                }
                if (arg2 > 22)
                {
                    result = "This is a problem";
                }
            }
            if (arg2 > 6)
            {
                result = "arg1" + arg2;
                if (result.Length > 5)
                {
                    result = "This is a problem2";
                }
            }
            return result;
        }

        public string OtherMethod(int arg1, int arg2)
        {
            if (arg1 < 17)
            {
                if (arg2 > 12)
                {
                    return "Happy";
                }
                if (arg2 > 22)
                {
                    return "This is a problem";
                }
                return "";
            }
            if (arg2 > 6)
            {
                String result = "arg1" + arg2;
                if (result.Length > 5)
                {
                    return "This is a problem2";
                }
                return result;
            }
            return "";
        }

    }
}