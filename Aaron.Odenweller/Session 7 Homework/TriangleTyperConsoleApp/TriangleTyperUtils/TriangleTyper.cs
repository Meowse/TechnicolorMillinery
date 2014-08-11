using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyperUtils
{
    public class TriangleTyper
    {
        private static long aVal;
        private static long bVal;
        private static long cVal;

        public string GetTriangleType(long a, long b, long c)
        {
            string triangleType;

            if (maxValCheck(a, b, c))
            {
                SetValues(a, b, c);
                triangleType = GetTriangleTypeForMax(a, b, c);
                ResetValues();
            }
            else
            {
               triangleType =  GetTriangleTypeForNonMax(a, b, c);

            }
            return triangleType;
        }

        private string GetTriangleTypeForNonMax(long a, long b, long c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "NotATriangle";
            }

            if ((a + b <= c) || (b + c <= a) || (c + a <= b))
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


        private bool maxValCheck(long a, long b, long c)
        {
            bool maxValUsed = false;

            if (a > long.MaxValue/2 || b > long.MaxValue/2 || c > long.MaxValue/2)
            {
                maxValUsed = true;
            }

            //Note The above statement can be rewritten as: bool maxValUsed = a > long.MaxValue/2 || b > long.MaxValue/2 || c > long.MaxValue/2;

            return maxValUsed;
        }

        private static void SetValues(long a, long b, long c)
        {

            aVal = a / 10;
            bVal = b / 10;
            cVal = c / 10;

            if (aVal == 0)
            {
                aVal = 1;
            }
            if (bVal == 0)
            {
                bVal = 1;
            }
            if (cVal == 0)
            {
                cVal = 1;
            }

        }

        private string GetTriangleTypeForMax(long a, long b, long c)
        {
             if (a <= 0 || b <= 0 || c <= 0)
            {
                return "NotATriangle";
            }

            if ((aVal + bVal <= cVal) || (bVal + cVal <= aVal) || (cVal + aVal <= bVal))
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



        private static void ResetValues()
        {
            aVal = 0;
            bVal = 0;
            cVal = 0;
        }

    
// For the contemplation of fundamental equivalence:
//            if (a == b || b == c || c == a)
//            {
//                return "Isosceles";
//            }
//            return "Scalene";

       }
}
