using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int rhymeLine = 0;
            while (rhymeLine <5)
            {
                Console.WriteLine("Happy Birthday to you! You might live in a zoo!!");
                if (rhymeLine ==3)
                {
                    Console.WriteLine("Happy Birthday dear friend!");

                }
                rhymeLine++;
           }
            Console.WriteLine("What is yoru age?");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            int count = 1;
            while (count <age)
            {
                Console.WriteLine("Happy Birthday to you!!!!");
                count++;
            }

            Console.ReadKey();
        }
    }
}
