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
            while (rhymeLine <6)
            {
                Console.WriteLine("Happy Birthday to you! You might live in a zoo!!");
                if (rhymeLine ==4)
                {
                    Console.WriteLine("Happy Birthday dear friend!");

                }
                rhymeLine++;
           }
            Console.ReadKey();
        }
    }
}
