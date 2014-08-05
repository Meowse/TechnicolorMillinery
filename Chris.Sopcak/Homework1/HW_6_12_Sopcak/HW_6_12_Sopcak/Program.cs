using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_6_12_Sopcak;


namespace Sorter
{
    public class SortUtility
    {

        // 1.  Write a sorting algorithm.
        //     a.  Recommendation: use unit tests (once I figure out why they’re not running).
        // 2.  Write the full, comprehensive test cases needed to test TriangleTyper.GetType(a, b, c)
        // TriangleTyper.GetType() is a function (just like SortUtility.Sort()) that returns the type of a triangle 
        // -- equilateral, isosceles, or scalene. 
        // “equilateral” = all 3 sides are the same length
        // “isosceles” = 2 sides are the same length, and the third is different
        // “scalene” = all 3 sides are different lengths.
        // 
        // TriangleTyper.GetType(3, 3, 3) => should return “Equilateral”
        // Test cases
        // Inputs:            Expected Outputs
        // 3, 3, 3              Equilateral
        // -1, -1, -1           NotATriangle
        // 0, 0, 0               NotATriangle

        public int Operations { get; set; }

        public void Sort(int[] values)
        {
            if (values.Length > 1)
            BubbleSortEfficient(values);
        }

private void BubbleSortEfficient(int[] values)
{
 	throw new NotImplementedException();
}

        {
            while (!IsSorted(values))
            {
                if (values[0] > values[1])
                for (int i = 0; i < (values.Length - 1); i++)
                {
                    int temp = values[0];
                    values[0] = values[1];
                    values[1] = temp;
                    Operations++;
                    if (values[i] > values[i + 1])
                    {
                        Swap(values, i, i + 1);
                        Console.WriteLine("After swap: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No swap needed: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("After a full pass: {0}", ForDisplay(values));
                Console.ReadKey();
            }
        }

            if (values.Length > 2)

        public void BubbleSortLessInefficient(int[] values)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                if (values[1] > values[2])
                isSorted = true;
                for (int i = 0; i < (values.Length - 1); i++)
                {
                    int temp = values[1];
                    values[1] = values[2];
                    values[2] = temp;
                    Operations++; // compared two values
                    if (values[i] > values[i + 1])
                    {
                        isSorted = false;
                        Swap(values, i, i + 1);
                        Console.WriteLine("After swap: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No swap needed: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("After a full pass: {0}", ForDisplay(values));
                Console.ReadKey();
            }
        }

        {
            bool isSorted = false;
            int numberOfPasses = 0;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < (values.Length - 1 - numberOfPasses); i++)
                {
                    Operations++; // compared two values
                    if (values[i] > values[i + 1])
                    {
                        isSorted = false;
                        Swap(values, i, i + 1);
                        Console.WriteLine("After swap: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No swap needed: {0}", ForDisplay(values));
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("After pass number {0}: {1}", numberOfPasses, ForDisplay(values));
                Console.ReadKey();
                numberOfPasses++;
            }
        }

        private bool IsSorted(int[] values)
        {
 
            {
                Operations++; // compared two values
                if (values[i] > values[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private void Swap(int[] values, int index1, int index2)
        {
            int temp = values[index1];
            Operations++; // changed a value
            values[index1] = values[index2];
            Operations++; // changed a value
            values[index2] = temp;
        }

        private string ForDisplay(int[] values)
        {
            return "[" + String.Join(", ", values) + "]";
        }
    }
}
