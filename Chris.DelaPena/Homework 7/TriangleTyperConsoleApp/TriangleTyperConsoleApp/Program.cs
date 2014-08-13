using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleTyperUtils;

namespace TriangleTyperConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TriangleTyper typer = new TriangleTyper();
            Triangle triangle = GetTriangle();
            while (triangle != null)
            {
                Console.WriteLine("Triangle typer returned {0} for triangle {1}.",
                    typer.GetTriangleType(triangle.A, triangle.B, triangle.C))
                ;
                triangle
                ;
            }
        }

        private static Triangle GetTriangle()
        {
            //Console.WriteLine("Please enter a triangle with whole-number sides:");
            //string inputs = Console.ReadLine();
            //inputs = inputs.Split(new string[]
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
}