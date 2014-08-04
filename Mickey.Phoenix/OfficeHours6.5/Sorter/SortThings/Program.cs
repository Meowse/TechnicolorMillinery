using System;
using System.Linq;
using Sorter;

namespace SortThings
{
    class Program
    {
        static void Main()
        {
            var sorter = new SortUtility();

            Console.WriteLine("Enter an algorithm and some numbers to sort, or 'exit' to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                string[] inputs = input.Split(new[] { " " }, 2, StringSplitOptions.None);
                string algorithm = inputs[0];
                if (inputs.Length == 1)
                {
                    return; 
                }
                int[] values = ParseInput(inputs[1]);
                SortWithAlgorithm(algorithm, sorter, values);
                DisplayOutput(values);

                Console.WriteLine("Enter an algorithm and some numbers to sort, or 'exit' to exit.");
                input = Console.ReadLine();
            }
        }

        private static void SortWithAlgorithm(string algorithm, SortUtility sorter, int[] values)
        {
            sorter.Operations = 0;
            switch (algorithm)
            {
                case "BubbleSortInefficient":
                    sorter.BubbleSortInefficient(values);
                    break;
                case "BubbleSortLessInefficient":
                    sorter.BubbleSortLessInefficient(values);
                    break;
                case "BubbleSortEfficient":
                    sorter.BubbleSortEfficient(values);
                    break;
                case "Sort":
                    sorter.Sort(values);
                    break;
                default:
                    algorithm = "Sort";
                    Console.WriteLine("Unrecognized algorithm, using basic sort.");
                    Console.WriteLine("Valid algorithms are: BubbleSortInefficient, BubbleSortLessInefficient, Sort");
                    sorter.Sort(values);
                    break;
            }
            Console.WriteLine("\nSorting with algorithm {0} took {1} operations.\n", algorithm, sorter.Operations);
        }

        private static int[] ParseInput(string userInput)
        {
            string[] inputs = userInput.Split(new [] {" ", ","}, StringSplitOptions.RemoveEmptyEntries);
            return inputs.Select(int.Parse).ToArray();
        }

        private static void DisplayOutput(int[] values)
        {
            Console.WriteLine("Sorted: " + String.Join(", ", values));
        }
    }
}
