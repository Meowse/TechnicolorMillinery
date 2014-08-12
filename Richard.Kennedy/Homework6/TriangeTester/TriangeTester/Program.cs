using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TriangeTester
{
    public class Program
    {
        private static void Main(string[] args)
        {
            TriangleTyper typer = new TriangleTyper();

            Console.WriteLine("Enter length of each side of the triangle, or 'exit' to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                long[] values = ParseInput(input);
                Console.WriteLine("Result is: " + typer.triangleCheck(values));
                input = Console.ReadLine();
            }
        }

        private static long[] ParseInput(string userInput)
        {
            string[] inputs = userInput.Split(new[] {" ", ","}, StringSplitOptions.RemoveEmptyEntries);
            return inputs.Select(long.Parse).ToArray();
        }

/*        private static void DisplayOutput(long[] values)
        {
            Console.WriteLine("Triangle side lengths: " + String.Join(", ", values));
        } */
    }
}