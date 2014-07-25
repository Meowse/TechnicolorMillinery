using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedConditionals
{
    class Program
    {
        private static const Dictionary<int, string> DIGITS =
            new Dictionary<int, string>
            { 
                {3, "Three"},
                {4, "Four"},
                {5, "Five"},
                {6, "Six"}
            };

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
            else if (value == 4)
            {
                Console.WriteLine("Four");
            }
            else if (value == 5)
            {
                Console.WriteLine("Five");
            }
            else if (value == 6)
            {
                Console.WriteLine("Six");
            }
            else
            {
                Console.WriteLine("Too big, don't know...");
            }

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
                case 6:
                        Console.WriteLine("Six");
                        break;
                default:
                        Console.WriteLine("Too big, don't know...");
                        break;
            }
        }

        private String nameFor(int value)
        {
            switch (value)
            {
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                default: return "Too big, don't know...";
            }
        }

        private String nameForFromDictionary(int value)
        {
            if (DIGITS.ContainsKey(value))
            {
                return DIGITS[value];
            }
            return "Too big, don't know...";
        }
    }
}
