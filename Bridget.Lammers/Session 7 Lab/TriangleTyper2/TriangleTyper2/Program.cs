using System;
using System.Linq;
using TriangleTyperUtils;

namespace TriangleTyper2
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
             * TriangleTyper.GetType() is a function that returns the type of a triangle -- equilateral, isosceles, or scalene.

                “equilateral” = all 3 sides are the same length
                “isosceles” = 2 sides are the same length, and the third is different
                “scalene” = all 3 sides are different lengths.

                TriangleTyper.GetType(3, 3, 3) => should return “Equilateral”
             * */
            Console.WriteLine("Enter three sides of our triangle and I will tell you what it is");
            Console.WriteLine("Enter exit to quit");
     
            string input = "";
            //int[] theNumbers = ParseInput(input); // returns an array of the integers entered.
            

            // take the input check what kind of triangle it is
            while (input != "exit")
            {
                input = Console.ReadLine();
                int[] theNumbers = TriangleTyper.ParseInput(input); // returns an array of the integers entered: theNumbers[x].

                string theResults = TriangleTyper.GetType(theNumbers[0], theNumbers[1], theNumbers[2]);
                //GetType() does all the work

                Console.WriteLine("the sides were: " + theNumbers[0] + " - " + theNumbers[1] + " - " + theNumbers[2]);
                Console.WriteLine("The type of your triangle is: " + theResults + "\n");
                //input = Console.ReadLine();
            }
            Console.ReadKey();
        }
        
    }
}
