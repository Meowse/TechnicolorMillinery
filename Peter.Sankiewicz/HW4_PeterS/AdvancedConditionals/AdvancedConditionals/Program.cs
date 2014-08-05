using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 3;
            if (value > 2)
            {
                Console.WriteLine("Bigger than 2");
            }
            else
            {
                Console.WriteLine("Smaller than 2");
            }
            if (value == 3)
            {
                Console.WriteLine("Three");
            }
            if (value == 4)
            {
                Console.WriteLine("Four");
            }
            if (value == 5)
            {
                Console.WriteLine("Five");
            }
            if (value == 6)
            {
                Console.WriteLine("Six");
            }
            else
            {
                Console.WriteLine("Too big, don't know");
            }
            Console.ReadKey();
            switch (value)
            {
                    case 3: 
                        Console.WriteLine("Three");
                    break;
                    case 4: 
                        Console.WriteLine("Four");
                    break;
                    case 5: 
                        Console.WriteLine("Five");
                    break;
                    case 6: Console.WriteLine("Six");
                    break;
                default: Console.WriteLine("Too big, don't know...");
            }
        }
    }
}
