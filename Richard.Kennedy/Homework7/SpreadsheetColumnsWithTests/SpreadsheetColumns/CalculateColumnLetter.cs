namespace SpreadsheetColumns
{
    public class CalculateColumnLetter
    {
        public static string GetColumnHeading(int columnNumber)
        {
            int divisor = columnNumber;
            string columnLetter = "";

            while (divisor > 0)
            {
                int modulus = (divisor - 1)%26;
                columnLetter = (char) (65 + modulus) + columnLetter;
                divisor = (divisor - modulus)/26;
            }

            return columnLetter;
        }
    }
}
