using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
                if (keyInfo.KeyChar == 'x' || keyInfo.KeyChar == 'X') break;

                char input = keyInfo.KeyChar == 13 ? '=' : keyInfo.KeyChar;
                calculator.ProvideInput(input);

                int numOfChar = Console.CursorLeft;
                for (int i = 0; i < numOfChar; i++) Console.Write("\b \b");
                Console.Write(calculator.GetDisplay());
            }

            Console.WriteLine();
        }
    }
}
