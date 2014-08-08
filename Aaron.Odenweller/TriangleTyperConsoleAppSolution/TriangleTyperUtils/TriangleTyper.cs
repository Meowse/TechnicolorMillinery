using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyperUtils
{
    public class TriangleTyper
    {
        public static string GetTriangleType(long a, long b, long c)
        {
            if (a < 1 || b < 1 || c < 1)
            {
                return "NotATriangle";
            }
            else if (a == b && b == c && a == c)
            {
                return "Equilateral";
            }

            else if (a != b && b != c && a != c)
            {
                return "Scalene";
            }

            else
            {
                return "Isosceles";
            }
        }
    }
}
