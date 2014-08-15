using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetColumns
{
    public class CalculateColumnLetter
    {
        public static string GetColumnHeading(int columnNumber)
        {
            int divisor = columnNumber;
            string columnLetter = "";
            int modulus = 0;

            while (divisor > 0)
            {
                modulus = (divisor - 1)%26;
                columnLetter = (char) (65 + modulus) + columnLetter;
                divisor = (int) ((divisor - modulus)/26);
            }
            //return columnLetter;

            string columnHeading = columnLetter;
            return columnHeading;
        }
    }
}
