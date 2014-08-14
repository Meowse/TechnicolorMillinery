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
            ulong uA = Convert.ToUInt64(a);
            ulong uB = Convert.ToUInt64(b);
            ulong uC = Convert.ToUInt64(c);
            if ((uA + uB <= uC) || (uB + uC <= uA) || (uC + uA <= uB))
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
