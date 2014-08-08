using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleTyperUtils
{
    public class TriangleTyperClass
    {
        public string GetTriangleType(long a, long b, long c)
        {
            //throw new NotImplementedException();
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                return "Not a Triangle";
            }

            if ((a + b <= c) || (b + c <= a) || (a + c <= b))
            {
                return "Not a Triangle";
            }

            if (a == b && b == c && a == c)                 
            {//a==c is not really needed but it makes its more clear to those that don't know geometry/logic
               return "Equilateral"; 
            }

            if (a != b && b != c && a != c)
            {
                return "Scalene";
            }

            return "Isosceles";
        }
    }
}
