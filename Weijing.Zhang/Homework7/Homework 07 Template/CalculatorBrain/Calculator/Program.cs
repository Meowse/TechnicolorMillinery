using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBrain;

namespace ConcoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator Usage:");
            Console.WriteLine("\t Type in your expression, result will be displayed after typing '='");
            Console.WriteLine("\t Use 'c' to clear, 'x' to exit");
            var calculator = new Calculator();
            Console.Write(calculator.GetDisplay());

            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                calculator.ProvideInput(keyInfo.KeyChar);
                if (keyInfo.KeyChar == 'x' || keyInfo.KeyChar == 'X') break;

                int numOfChar = Console.CursorLeft;
                for (int i = 0; i < numOfChar; i++) Console.Write("\b \b");
                Console.Write(calculator.GetDisplay());
            }

            Console.WriteLine();
        }
    }
}
