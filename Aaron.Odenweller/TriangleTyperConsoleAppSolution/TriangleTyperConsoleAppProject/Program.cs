using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleTyperUtilsTests;
using TriangleTyperUtils;


namespace TriangleTyperConsoleAppProject
{
    class Program
    {
        private static String input;
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("Enter 3 digits, separated by commas.  Type 'Exit' to exit.");
                input = Console.ReadLine();
                string[] arrayOfInputs = input.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

                if (input != "Exit")
                {
                    
                    var response = TriangleTyper.GetTriangleType(long.Parse(arrayOfInputs[0]), long.Parse(arrayOfInputs[1]), long.Parse(arrayOfInputs[2]));
                    Console.WriteLine(response);
                }

                Console.ReadKey();
            } while (input != "Exit");
            //SimpleTriangleTyperTests.EqualSidesShouldBeEquilateral();
            //SimpleTriangleTyperTests.TwoSidesEqualShouldBeIsosceles();
        }
    }
}
