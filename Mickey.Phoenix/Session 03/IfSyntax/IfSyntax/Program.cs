using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            
            int total = int.Parse(userInput);

            if (IsBig(total))
            {
                Console.WriteLine("First value is big");
            }

            total = total * 2;

            if (IsBig(total))
            {
                Console.WriteLine("Second value is big");
            }

            total = total + 5;

            if (IsBig(total))
            {
                Console.WriteLine("Third value is big");
            }

            if (IsBig(3 + 4) || IsBig(12) || IsBig(13))
            {
                Console.WriteLine("Big, scary number!");
            }

            Console.ReadKey();
        }

        static bool IsBig(int number)
        {
            if (number > 10)
            {
                Console.WriteLine("It's big!");
                return true;
            }
            else
            {
                Console.WriteLine("It's small!");
                return false;
            }
        }
    }
}
