using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a column number to be converted to a column letter, or 'exit' to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                int columnNumber = Convert.ToInt32(input);
                var columnHeading = CalculateColumnLetter.GetColumnHeading(columnNumber);
                Console.WriteLine("Column " + columnNumber + " is column letter " + columnHeading + "\n");
                input = Console.ReadLine();
            } 
        }
    }
}
