using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happybirthdaytoyou
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
                 
                        Console.WriteLine("Happy birthday, dear {0}!", name);
                    }
                    else
                    {
                        Console.WriteLine();

                        if (now.Hour < 12)
                        {
                            Console.WriteLine("Good morning to you, {0}!", name);
                        }
                        else if (now.Hour < 17)
                        {
                            Console.WriteLine("Sorry, I'm taking a siesta. Please come back after 5pm.");
                        }
                        else
                        {
                            Console.WriteLine(@"
                    Twinkle, twinkle, little star
                    How I wonder what you are!
                    Up above the world so high
                    Like a diamond in the sky
                    Twinkle, twinkle, little star
                    How I wonder what you are");
                        }     

                    }
                
                
            Console.ReadKey();

        }
    }
}
