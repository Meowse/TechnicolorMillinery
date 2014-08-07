using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyper2
{
    class Program
    {
        static void Main(string[] args)
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
                int[] theNumbers = ParseInput(input); // returns an array of the integers entered.

                string theResults = GetType(theNumbers[0], theNumbers[1], theNumbers[2]);
                Console.WriteLine("the sides were: " + theNumbers[0] + "-" + theNumbers[1] + "-" + theNumbers[2]);
                Console.WriteLine("Your triangle is: " + theResults + "\n");
                //input = Console.ReadLine();
            }
            Console.ReadKey();
        }

        public static int[] ParseInput(string userInput)
        {
            string[] inputs = userInput.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            return inputs.Select(int.Parse).ToArray();
        }

        public static string GetType(Int32 sideA, Int32 sideB, Int32 sideC)
        {
     
             /* “equilateral” = all 3 sides are the same length
                “isosceles” = 2 sides are the same length, and the third is different
                “scalene” = all 3 sides are different lengths.
            */

            if ((sideA == sideB) && (sideB == sideC))
            {
                 // “equilateral” = all 3 sides are the same length
                return "equilateral";
            }


            if ( ((sideA == sideB) && (sideC != sideA)) | ((sideB == sideC) && (sideA !=sideB)) )
            {
                //“isosceles” = 2 sides are the same length, and the third is different
                return "isosceles";
            }

            if ((sideA != sideB) && (sideB != sideC))
            {
                //“scalene” = all 3 sides are different lengths.
                return "scalene";
            }

            return "None found"; // default
        }
    }
}
