using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1_Sorter_Sopcak
{
    class Program
    {
        static void Main()
        {
            var sorter = new SortUtility();

            Console.WriteLine("Enter numbers to sort, or 'exit' to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                int[] values = ParseInput(input);
                sorter.Sort(values);
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