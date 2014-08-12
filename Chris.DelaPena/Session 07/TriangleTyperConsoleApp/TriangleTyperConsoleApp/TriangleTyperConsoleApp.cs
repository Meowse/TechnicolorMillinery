using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyperConsoleApp
{
    class TriangleTyperConsoleApp
    {
        static void Main(string[] args)
        {
            Triangle triangle = GetTriangle();
            while (triangle != null)
            {
                Console.WriteLine("TriangleTyper retured {0} for triangle {1}." triangle);
            }
        }

        private static Triangle GetTriangle()
        {
            Console.WriteLine("Please enter a triangle with whole number sides:");
            string inputs = Console.ReadLine();
            inputs = inputs.Split(new string[] {",", " "}, StringSplitOptions.RemoveEmptyEntries);
        }
    }

    internal class Triangle
    {
        long a   
    }
}
