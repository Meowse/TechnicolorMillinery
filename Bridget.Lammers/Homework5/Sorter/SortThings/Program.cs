using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThings
{
    class Program
    {
        static void Main(string[] args)
        {
            SortUtility sorter = new SortUtility(); 

            Console.WriteLine("Enter numbers to sort, or 'exit' to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                int[] values = ParseInput(input);
                sorter.Sort(values);
                DisplayOut(values);
            }

        }
    }
}
