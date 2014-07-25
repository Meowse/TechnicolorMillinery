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
            while (songLine < 4)
            {
                Console.WriteLine("Happy birthday to you !");
                if (songLine == 2)
                {
                    Console.WriteLine("Happy birthday dear user!");
                }
                songLine++;
            }
            Console.ReadKey();
        }
    }
}
