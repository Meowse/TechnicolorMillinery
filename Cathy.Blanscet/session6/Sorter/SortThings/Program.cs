using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorter;

namespace SortThings
{
    class Program
    {
        static void Main()
        {
            SortUtility sorter = new SortUtility();
            Console.WriteLine("enter numbers to sort, or exit to exit");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                int[] values = ParseInput(input);
                sorter.Sort(values);
                DisplayOutput(values);
            }
        }

        private static int[] ParseInput(string userInput)
        {
        }

        private static void DisplayOutput(int[] values)
        {
            Console.WriteLine("Sorted: " + String.Join(", ", values));
        }
    }
}
