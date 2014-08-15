using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleTyperUtils
{
    public class TriangleTyper
    {
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


            if (((sideA == sideB) && (sideC != sideA)) || ((sideB == sideC) && (sideA != sideB)))
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
