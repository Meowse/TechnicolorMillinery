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
            if (a == b && b == c && c == a)
            {
                return "Equilateral";
            }
            return "Isoscoles";
        }
    }
}
