using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TriangeTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter length of each side of the triangle, or 'exit' to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                long[] values = ParseInput(input);
                //Console.WriteLine("Before triangleCheck");
//                triangleCheck(values);
                Console.WriteLine("Result is: " + triangleCheck(values));
                //Console.WriteLine("After triangleCheck");
                //DisplayOutput(values);

                input = Console.ReadLine();
            }
        }

        private static long[] ParseInput(string userInput)
        {
            string[] inputs = userInput.Split(new[] {" ", ","}, StringSplitOptions.RemoveEmptyEntries);
            return inputs.Select(long.Parse).ToArray();
        }

        private static void DisplayOutput(long[] values)
        {
            Console.WriteLine("Triangle side lengths: " + String.Join(", ", values));
        }

        private static string triangleCheck(long[] values)
        {
            long sideA = values[0];
            long sideB = values[1];
            long sideC = values[2];
            //Console.WriteLine("Starting triangleCheck");

            // Check for length of any side less than or equal to zero
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Not a triangle -- Length of all side must be a positive integer.");
                return "Not a triangle";
            }
            //Console.WriteLine("Stopping triangleCheck");

            if ((sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA))
            {
                Console.WriteLine("Not a triangle -- Vertices don't meet.");
                return "Not a triangle";
            }

            int numberOfEqualSides = 0;
            if (sideA == sideB)
            {
                numberOfEqualSides++;
            }
            if (sideB == sideC)
            {
                numberOfEqualSides++;
            }

            switch (numberOfEqualSides)
            {
                case 0:
//                    Console.WriteLine("Scalene Triangle");
                    return "Scalene Triangle";
                case 1:
//                    Console.WriteLine("Isosceles Triangle");
                    return "Isosceles Triangle";
                case 2:
//                    Console.WriteLine("Equalateral Triangle");
                    return "Equalateral Triangle";
                default:
                    return "Unkown Triangle";
            }
        }
    }
}