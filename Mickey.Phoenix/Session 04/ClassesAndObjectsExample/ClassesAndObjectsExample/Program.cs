using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndObjectsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();


            int[] arg1TestCase = { -5, -1, 0, 1, 5, 6, 7, 8, 9, 10, 11, 15, 17, 19, 21, 22, 23, 25, 26 };
            int[] arg2TestCase = { -5, -1, 0, 1, 5, 6, 7, 8, 9, 10, 11, 15, 17, 19, 21, 22, 23, 25, 26 };

            bool anyTestFailed = false;
            foreach (int arg1 in arg1TestCase)
            {
                foreach (int arg2 in arg2TestCase)
                {
                    string result = person.SomeMethod(arg1, arg2);
                    if ((arg2 < 7) && (result != ""))
                    {
                        Console.WriteLine("Invalid result for (" + arg1 + "," + arg2 + "): expected \"\", but was " + result);
                        anyTestFailed = true;
                    }
                    else if ((arg2 == 7) && (result != "arg17"))
                    {
                        Console.WriteLine("Invalid result for (" + arg1 + "," + arg2 + "): expected \"arg17\", but was " + result);
                        anyTestFailed = true;
                    }
                    else if ((arg2 == 8) && (result != "arg18"))
                    {
                        Console.WriteLine("Invalid result for (" + arg1 + "," + arg2 + "): expected \"arg18\", but was " + result);
                        anyTestFailed = true;
                    } 
                    else if ((arg2 == 9) && (result != "arg19"))
                    {
                        Console.WriteLine("Invalid result for (" + arg1 + "," + arg2 + "): expected \"arg19\", but was " + result);
                        anyTestFailed = true;
                    }
                    else if ((arg2 >= 10) && (result != "Ooops..."))
                    {
                        Console.WriteLine("Invalid result for (" + arg1 + "," + arg2 + "): expected \"Ooops...\", but was " + result);
                        anyTestFailed = true;
                    }
                }
            }
            if (anyTestFailed)
            {
                Console.WriteLine("TEST FAILED!!!");
            }
            else
            {
                Console.WriteLine("All tests passed!");
            }
            Console.ReadKey();



//            int[] arg1TestCase = { -5, -1, 0, 1, 5, 6, 7, 8, 9, 10, 11, 15, 17, 19, 21, 22, 23, 25, 26 };
//            int[] arg2TestCase = { -5, -1, 0, 1, 5, 6, 7, 8, 9, 10, 11, 15, 17, 19, 21, 22, 23, 25, 26 };
//
//            foreach (int arg1 in arg1TestCase)
//            {
//                foreach (int arg2 in arg2TestCase)
//                {
//                    Console.WriteLine("Value for inputs (" + arg1 + "," + arg2 + ") is " + person.SomeMethod(arg1, arg2));
//                }
//            }
//            Console.ReadKey();



//            Console.WriteLine("Enter a number to test, or 'exit' to quit.");
//            String input = Console.ReadLine();
//            while (input != "exit")
//            {
//                if (input.Length == 0)
//                {
//                    input = Console.ReadLine();
//                    continue;
//                }
//                int arg = int.Parse(input);
//                Console.WriteLine("Answer for input " + arg + " is " + person.SomeMethod(arg, arg));
//                input = Console.ReadLine();
//            }
        }
    }
}
