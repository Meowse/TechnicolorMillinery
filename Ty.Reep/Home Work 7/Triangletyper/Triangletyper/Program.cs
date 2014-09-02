using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleTyperUtils;

namespace Triangletyper
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleTyper typer = new TriangleTyper();
            Triangle triangle = GetTriangle();

        }

        private static Triangle GetTriangle()
        {
            Console.WriteLine("Please enter a triangle with whole-number sides:");
            string input = Console.ReadLine();
            if (input != null)
            {
                string[] inputs = input.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            }
            return new Triangle();
        }
    }

    internal class Triangle
    {
        public long A;
        public long B;
        public long C;
    }
}
