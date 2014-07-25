using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_Part_1_redo
{
    class Program
    {
        static void Main(string[] args)
        {
            int songLine = 0;
            while (songLine < 3)
            {
                Console.WriteLine("Happy birthday to you!");
                if (songLine == 2)
                {
                    Console.WriteLine("Happy birthday dear user!");
                }
                songLine++;
            }
            Console.WriteLine("How old are you?");
            String ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            int counter = 1;
            while (counter < age)
            {
                Console.WriteLine("Happy birthday to you!");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
