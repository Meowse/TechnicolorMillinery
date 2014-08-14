using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyperUtils
{
    public class TriangleTyper
    {
        public string GetTriangleType(long a, long b, long c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "NotATriangle";
            }


            //changed the math to substruct instead of add.  Then switch the symbols for "less than equal to" into "greater than equal to" 

            if ((a - b >= c) || (b - c >= a) || (c - a >= b))
            {
                return "NotATriangle";
            }

            if (a == b && b == c && c == a)
            {
                return "Equilateral";
            }

            if (a != b && b != c && a != c)
            {
                return "Scalene";
            }

            return "Isosceles";
        }

// For the contemplation of fundamental equivalence:
//            if (a == b || b == c || c == a)
//            {
//                return "Isosceles";
//            }
//            return "Scalene";
    }
}
