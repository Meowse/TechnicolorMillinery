using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleStuff
{
    public class TriangleTyper
    {
        public string getType(long a, long b, long c)
        {
           
            
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "NotATriangle";
            }else if ((a + b == c) || (b + c == a) || (c + a == b))
            {
                return "NotATriangle";
            }else if (((a == b) && (b != c)) || ((a == c) && (c !=b)) || ((b == c) && (c != a)))
            {
                return "Isosolese";
            }else if ((a == b) && (b == c) && (a == c))
            {
                return "Equilateral";
            }else if ((a != b) && (b != c) && (a != c))
            {
                return "Scalene";
            }else
            {
                return "";
            }
        }

    }
}
