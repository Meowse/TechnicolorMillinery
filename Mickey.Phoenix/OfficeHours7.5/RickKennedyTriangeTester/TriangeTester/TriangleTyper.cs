using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangeTester
{
    public class TriangleTyper
    {
        public string triangleCheck(long[] values)
        {
            long sideA = values[0];
            long sideB = values[1];
            long sideC = values[2];
            //Console.WriteLine("Starting triangleCheck");

            // Check for length of any side less than or equal to zero
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Not a triangle -- Length of all side must be a positive integer.");
                return "Not a triangle";
            }
            //Console.WriteLine("Stopping triangleCheck");

            if ((sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA))
            {
                Console.WriteLine("Not a triangle -- Vertices don't meet.");
                return "Not a triangle";
            }

            int numberOfEqualSides = 0;
            if (sideA == sideB)
            {
                numberOfEqualSides++;
            }
            if (sideB == sideC)
            {
                numberOfEqualSides++;
            }

            switch (numberOfEqualSides)
            {
                case 0:
                    //                    Console.WriteLine("Scalene Triangle");
                    return "Scalene Triangle";
                case 1:
                    //                    Console.WriteLine("Isosceles Triangle");
                    return "Isosceles Triangle";
                case 2:
                    //                    Console.WriteLine("Equalateral Triangle");
                    return "Equalateral Triangle";
                default:
                    return "Unkown Triangle";
            }
        }
    }
}
