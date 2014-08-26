using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string birthdateString = null;
            DateTime birthdate;

            do
            {
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));


            do
            {
                Console.WriteLine("Please enter your date of birth (MM/dd/yyyy):");
                birthdateString = Console.ReadLine();
            } while (string.IsNullOrEmpty(birthdateString) || !DateTime.TryParse(birthdateString, out birthdate) || birthdate > DateTime.Now);

            Console.WriteLine();
            DateTime now = DateTime.Now;
            if (birthdate.Month == now.Month && birthdate.Day == now.Day)
            {
                SingHappyBirthday(name);

                Console.WriteLine();
                for (int i = 0; i < now.Year - birthdate.Year; i++)
                {
                    Console.WriteLine("Happy birthday for your age {0}: {1}", i + 1, GetBinaryAge(i + 1));
                }
            }
            else
            {

                if (now.Hour < 12)
                {
                    Console.WriteLine("Good morning coffee\n" +
            "Good morning coffee\n" +
             "The earth says hello\n" +
             "You twinkle above us\n" +
             "We tinkle below\n" +
             "Good morning coffee\n" +
             "You lead us along\n" +
             "My coffee and me as we sing this song\n" +
             "Our morning coffee singing song");
                }
                else if (now.Hour < 17)
                {
                    Console.WriteLine("Beer! It's my siesta!!!");
                }
                else
                {
                    Console.WriteLine(@"Nights in white satin never reaching the end\n" +
        "Letters I've written never meaning to send\n" +
        "Beauty I'd always missed with these eyes before\n" +
        "Just what the truth is I can't say anymore\n" +
        "Cos I love you yes I love you, oh how I love you\n" +
        "Gazing at people some hand in hand\n" +
        "Just what I'm going through they can't understand\n" +
        "Some try to tell me thoughts they cannot defend\n" +
        "Just what you want to be, you will be in the end");
                }

            }

            Console.ReadKey();
        }

        static void SingHappyBirthday(string name)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Happy birthday, dear {0}!", name);
                }
                else
                {
                    Console.WriteLine("Happy birthday to you.");
                }
            }
        }

        static string GetBinaryAge(int age)
        {
            string ageBinary = string.Empty;
            while (age > 0)
            {
                ageBinary = (age % 2) + ageBinary;
                age /= 2;
            }
            return ageBinary;
        }
    }
}

   

