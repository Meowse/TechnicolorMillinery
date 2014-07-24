using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_5_Sopcak_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please provide your name:  "); //Request user name input
            string yourName = Console.ReadLine();

            Console.Write("Please provide your birthday:  "); //Request user date input
            DateTime yourBday = DateTime.Parse(Console.ReadLine()); //Parse the date into DateTime data type

            //Compare users birthday to today and sing happy birthday if it is today. Otherwise tell them to leave.
            if (yourBday.DayOfYear == DateTime.Now.DayOfYear)
            {
                SingHappyBirthday(yourName, yourBday);
            }
            else
            {
                Console.WriteLine("Sorry, it's not your birthday.");
                Console.ReadKey();
            }



        }

        static void SingHappyBirthday(string name, DateTime bday)
        {
            int x = 0;
            //Loop the happy birthday song, filling in the user input name
            while (x < 2)
            {
                Console.WriteLine("Happy Birthday to you.");
                x = x + 1;
            }
            Console.WriteLine("Happy Birthday to " + name);
            Console.WriteLine("Happy Birthday to you!");
            Console.ReadKey();

        }
    }
}
