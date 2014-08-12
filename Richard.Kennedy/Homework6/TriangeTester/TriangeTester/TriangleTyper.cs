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

            // Check for length of any side less than or equal to zero
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return "Not a triangle";
            }

            if ((sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA))
            {
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
                    return "Scalene Triangle";
                case 1:
                    return "Isosceles Triangle";
                case 2:
                    return "Equalateral Triangle";
                default:
                    return "Unknown Triangle";
            }
        }
    }
}
