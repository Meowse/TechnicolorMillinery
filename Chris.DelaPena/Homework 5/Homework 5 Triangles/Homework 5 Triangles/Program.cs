using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Triangles
{
    class Program
    {
        static void Main()
        {
            var triTyper = new TriangleTyper.TriangleTyper();
            Console.WriteLine("Enter lengths of 3 sides");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                int[] values = ParseInput(input);
                triTyper.GetType(values);
                DisplayOutput(values);

                input = Console.ReadLine();
            }
        }

        private static int[] ParseInput(string userInput)
        {
            string[] inputs = userInput.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            return inputs.Select(int.Parse).ToArray();
        }

        private static void DisplayOutput(int[] values)
        {
            Console.WriteLine("Sorted: " + String.Join(", ", values));
        }
    }
}
