using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for MergeSort By Recursive Method");
            string input = Console.ReadLine();
            int[] numbers = ParseInput(input);

            // take the input and sort it unless it is exit then stop
            while (input != "exit")
            {
                RecursiveMergeSort(numbers, 0, numbers.Length - 1);
                Console.WriteLine("Sorted: " + String.Join(", ", numbers));           
                input = Console.ReadLine();
            }
        }

        // get the numbers to sort from user and store in an array
        private static int[] ParseInput(string userInput)
        {
            string[] inputs = userInput.Split(new [] {" ", ","}, StringSplitOptions.RemoveEmptyEntries);
            return inputs.Select(int.Parse).ToArray();
        }

        //recursively called method
        public static void RecursiveMergeSort(int[] numbers, int vLeftSide, int vRightSide)
        {
            if (vRightSide > vLeftSide)
            {
                int mid = (vRightSide + vLeftSide) / 2;
                RecursiveMergeSort(numbers, vLeftSide, mid);
                RecursiveMergeSort(numbers, (mid + 1), vRightSide);
                DoTheMerge(numbers, vLeftSide, (mid + 1), vRightSide);
            }
        }

        //
        public static void DoTheMerge(int[] numbers, int vLeft, int midPt, int vRight)
        {
            int[] temp = new int[numbers.Length*2]; //temporary array twice the size of the original array
            int leftEnd = (midPt - 1);
            int tmpPos = vLeft;
            int numElements = (vRight - vLeft + 1);

            while ((vLeft <= leftEnd) && (midPt <= vRight))
            {
                if (numbers[vLeft] <= numbers[midPt])
                {
                    temp[tmpPos++] = numbers[vLeft++];
                }
                else
                {
                    temp[tmpPos++] = numbers[midPt++];
                }
            }

            while (vLeft <= leftEnd)
            {
                temp[tmpPos++] = numbers[vLeft++];
            }

            while (midPt <= vRight)
            {
                temp[tmpPos++] = numbers[midPt++];
            }

            for (int i = 0; i < numElements; i++)
            {
                numbers[vRight] = temp[vRight];
                vRight--;
            }
        }
    }
}
