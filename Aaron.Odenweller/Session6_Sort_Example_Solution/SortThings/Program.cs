using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session6_Sort_Example_Project;


namespace SortThings
{
    class Program
    {
        static void Main()
        {

             var aSorter = new Sorter();

            Console.WriteLine("Enter numbers to sort, or 'exit' to exit.");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                int[] values = ParseInput(input);
                aSorter.Sort(values);
                DisplayOutput(values);

                input = Console.ReadLine();
            }
        }

        private static int[] ParseInput(string anInput)
        {
            string[] inputs = anInput.Split(new[] {" ", ","}, StringSplitOptions.RemoveEmptyEntries); // This Split method takes the User's input and then takes it apart into space and comma separated numbers
            return inputs.Select(int.Parse).ToArray(); // The select method selects everything in the Array and then returns them.  ToArray, says take those values and turn them into an Array
        }

        private static void DisplayOutput(int[] values)
        {
            Console.WriteLine("Sorted: " + String.Join(", ", values));
        }
    }
}
