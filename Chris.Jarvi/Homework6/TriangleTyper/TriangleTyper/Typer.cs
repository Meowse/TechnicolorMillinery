using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyper
{
    public class Typer
    {
        public string GetType(long side1, long side2, long side3)
        {
            if (side1 < 1 || side2 < 1 || side3 < 1)
            {
                return "";
            }

            int equalSides = 0;
            if (side1 == side2)
            {
                equalSides++;
            }
            if (side2 == side3)
            {
                equalSides++;
            }
            if (side1 == side3)
            {
                equalSides++;
            }
            switch (equalSides)
            {
                case 0:
                    return "Scalene";
                case 1:
                    return "Isosceles";
                case 3:
                    return "Equilateral";
                default:
                    return "";
            }
            
        }
    }
}
