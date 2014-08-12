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
                int divisor = Convert.ToInt32(input);
                int columnNumber = divisor;
                string columnLetter = "";
                int modulus = 0;

                while (divisor > 0)
                {
                    modulus = (divisor - 1) % 26;
                    columnLetter = (char)(65 + modulus) + columnLetter;
                    divisor = (int)((divisor - modulus) / 26);
                }
                //return columnLetter;
                Console.WriteLine("Column " + columnNumber + " is column letter " + columnLetter + "\n");
                input = Console.ReadLine();
            } 
        }

    }
}
