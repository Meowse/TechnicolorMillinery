using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Making an empty dictionary and then adding key/value pairs one at a time
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(3, "Three");
            dict.Add(4, "Four");
            dict.Add(5, "Five");
            dict.Add(6, "Six");

            // Using the built-in C# "static initializer syntax" for dictionaries
            Dictionary<int, string> dict2 = new Dictionary<int, string>
            {
                {3, "Three"},
                {4, "Four"},
                {5, "Five"},
                {6, "Six"}
            };

            // Making an empty list and then adding values one at a time
            List<int> ints = new List<int>();
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);

            // Using the built-in C# "static initializer syntax" for lists
            List<int> ints2 = new List<int> { 3, 4, 5 };

            Console.WriteLine("One");
            switch (ints2[1])
            {
                case 3:
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            Console.WriteLine("Two");

            int val = 4;

            // Not legal, because the if-statement is a statement, and does not have a value
            //string name = if (val == 4) { "fred" } else { "barney" }

            // Legal, but very verbose.  Takes nine lines to set name2 based on the value of val
            string name2;
            if (val == 4) 
            {
                name2 = "fred";
            }
            else
            {
                name2 = "barney";
            }
            
            // Legal, because the "?:" operator is an expression, and has a value
            var name3 = (val == 4) ? dict[5] : "barney" + dict2[3];

            // "x" is "(val == 4)", "y" is "fred", and "z" is "barney".
            // if (val == 4) is true, name3 will be "fred".  If it's false, name3 will be "barney".

            Console.WriteLine("Name3 is " + name3);
            Console.WriteLine(addIt(3, 4));
            Console.WriteLine(addIt(1.5f, 2.8f));
            Console.WriteLine(addIt(true, false));
            Console.WriteLine(addIt("fred", "barney"));

            if (ninetyNinePointNineNineNinePercentOfTheTime)
            {
                Console.WriteLine(addIt(3, 4));
            }
            else
            {
                Console.WriteLine(addIt(true, false));
            }


            Console.ReadKey();
        }

        private static int addIt(int op1, int op2)
        {
            return op1 + op2;
        }

        private static float addIt(float op1, float op2)
        {
            return op1 + op2;
        }

        private static string addIt(string op1, string op2)
        {
            return op1 + op2;
        }
    }
}
