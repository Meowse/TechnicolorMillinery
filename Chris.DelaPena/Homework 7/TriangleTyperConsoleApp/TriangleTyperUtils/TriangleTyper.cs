using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyperUtils
{
    public class TriangleTyper
    {
        public string GetTriangleType(long a, long b, long c) //change from int to long, go from ii to alphanumeric
        {

            //need several or commands
            //check greater than zero
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "NotATriangle";
            }
            //for add up, do <=
            if ((a + b <= c) || (b + c <= a) || (c + a <= b))
            {
                return "NotATriangle";
            }

            //Make a return statement for isoscoles
            if (a == b && b == c && c == a)
            {
                return "Equilateral";
            }

            //return scalene if a!=b and b!=c, but you need more (or fails isoscoles
            //inclue a !=c
            if (a != b && b != c && a != c)
            {
                return "Scalene";
            }
            //if a == b || b == c || c == a return isoscoles
            return "Isoscoles";
        }
    }
}
