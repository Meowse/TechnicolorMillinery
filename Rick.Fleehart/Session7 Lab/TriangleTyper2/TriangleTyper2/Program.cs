using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
             * 
             * 1,1,1 Equalateral
             * 1,2,2 Isosoles
             * 1,2,3 not a triangle
             * 1,1,2 not a triangle
             * 3,4,5 Scalene
           */

            // Check to see if the numbers given is a triangle
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return "NotATriangle";
            }

            if ((sideA + sideB) <= sideC || (sideA + sideC) <= sideB || (sideB + sideC) <= sideA)
            {
                return "NotATriangle";
            }

            //--- it is a triangle, now check which kind


            if ((sideA == sideB) && (sideB == sideC))
            {
                 // “equilateral” = all 3 sides are the same length
                return "equilateral";
            }


            if ( ((sideA == sideB) && (sideC != sideA)) || ((sideB == sideC) && (sideA !=sideB)) )
            {
                //“isosceles” = 2 sides are the same length, and the third is different
                return "isosceles";
            }

            if ((sideA != sideB) && (sideB != sideC))
            {
                //“scalene” = all 3 sides are different lengths.
                return "scalene";
            }

            return "Unknown"; // default
        }
    }
}
