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

            // put the zero and negative number tests first so that they won't match any of the other types
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                return "Not a Triangle";
            }

            // this test for valid triangle 
            // can't handle long.MaxValue; could move it below the other tests but then might not get isosceles
            // a try-catch is best
            try
            {
                if ((a + b <= c) || (b + c <= a) || (a + c <= b))
                {
                    return "Not a Triangle";
                }
            }
            catch
            {
                return HugeNumbersTest(a, b, c);
            }

            //a==c is not really needed but it makes its more clear to those that don't know geometry/logic
            if (a == b && b == c && a == c)                 
            {
               return "Equilateral"; 
            }

            if (a != b && b != c && a != c)
            {
                return "Scalene";
            }

            return "Isosceles";
        }

        private string HugeNumbersTest(long a , long b , long c )
        {
            if (a == b && b == c && a == c)
            {
                return "Equilateral";
            }

            if (a == long.MaxValue)
            {
                if (b <= (a/2) && c <= (a/2))
                {
                    return "Not a Triangle";
                }

                if ((a == b && b != c) || (a == c && a != b))
                {
                    return "Isosceles";
                }

                if (a != b && a != c && b != c)
                {
                    return "Scalene";
                }
            }

            if (b == long.MaxValue)
            {
                if (a <= (b / 2) && c <= (b / 2))
                {
                    return "Not a Triangle";
                }

                if ((a == b && b != c) || (a == c && a != b))
                {
                    return "Isosceles";
                }

                if (a != b && a != c && b != c)
                {
                    return "Scalene";
                }
            }

            if (c == long.MaxValue)
            {
                if (a <= (c / 2) && b <= (c / 2))
                {
                    return "Not a Triangle";
                }

                if ((a == b && b != c) || (a == c && a != b))
                {
                    return "Isosceles";
                }

                if (a != b && a != c && b != c)
                {
                    return "Scalene";
                }
            }

            return "Isosceles";
        }
    }
}
