﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter your name:"); //Request user name input
            string yourName = Console.ReadLine();

            Console.Write("Please enter your birthday (DD/MM/YYYY):"); //Request user date input
            DateTime yourBday = DateTime.Parse(Console.ReadLine()); //Parse the date into DateTime data type

            //Compare users birthday to today and sing happy birthday if it is today. Otherwise tell them to leave.
            if (yourBday.DayOfYear == DateTime.Now.DayOfYear) 
            {
                SingHappyBirthday(yourName, ref yourBday);
                Console.ReadKey();
            }
                else
            {
                SingOtherSong();
                Console.ReadKey();
            }
          
        }

        static void SingHappyBirthday(string name, ref DateTime bday)
        {
            
            //Loop the happy birthday song, filling in the user input name
            while (DateTime.Now.Year >= bday.Year)
            {
                    Console.WriteLine("Happy Birthday to you,");
                    Console.WriteLine("Happy Birthday to you,");
                    Console.WriteLine("Happy Birthday dear " + name +",");
                    Console.WriteLine("Happy Birthday to you!");
                    bday = bday.AddYears(1);
            }

        }
        static void SingOtherSong()
        {
            int noon = 12;
            int evening = 17;
            int x = 0;

            if (DateTime.Now.Hour < noon)
            {
                while (x < 2)
                {
                    Console.WriteLine("Good Morning, Good Morning, Good Morning to you!");
                    x = x + 1;
                }
                Console.WriteLine("Our day is beginning, there's so much to do \n" +
"So, good morning, good morning, good morning to you");
                Console.ReadKey();
            }
            else if (DateTime.Now.Hour >= noon & DateTime.Now.Hour < evening)
            {
                Console.WriteLine("I'm taking a siesta. Please come back later.");
                Console.ReadKey();
            }
            else if (DateTime.Now.Hour > evening)
            {
                Console.WriteLine(@"Twinkle, twinkle, little star
How I wonder what you are!
Up above the world so high
Like a diamond in the sky
Twinkle, twinkle, little star
How I wonder what you are");
            }
        }
    }
}

