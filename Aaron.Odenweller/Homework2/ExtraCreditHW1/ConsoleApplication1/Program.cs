using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Aaron\Documents\GitHub\TechnicolorMillinery\Aaron.Odenweller\Homework1\WindowsFormsApplicationHW1\WindowsFormsApplicationHW1\How to brush your teeth.txt");
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
