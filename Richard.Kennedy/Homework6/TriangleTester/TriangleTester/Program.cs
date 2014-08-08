using System;
using System.Linq;

namespace TriangleTester
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter length of each side of the triangle, or 'exit' to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                int[] values = ParseInput(input);
                triangleCheck(values);
                DisplayOutput(values);

                input = Console.ReadLine();
            }
        }

        private static int[] ParseInput(string userInput)
        {
            string[] inputs = userInput.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            return inputs.Select(int.Parse).ToArray();
        }

        private static int[] triangleCheck(int side1, int side2, int side3)
        {
            //Check if any side is less than or equal to zero
            int good = 1;
            int bad = -1;
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                return bad;
            }
            else
            {
                return good;
            }
        }

        private static void DisplayOutput(int[] values)
        {
            Console.WriteLine("Triangle side lengths: " + String.Join(", ", values));
        }
    }
}