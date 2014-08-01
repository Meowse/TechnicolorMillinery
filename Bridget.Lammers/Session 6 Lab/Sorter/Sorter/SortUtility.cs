using System;

namespace Sorter
{
    public class SortUtility
    {
        public void Sort(int[] values)
        {
            // Read a value with "values[3]"
            // Write a value with "values[2] = 17"
            // Get the number of values with "values.Length"

            // First value in the array is "values[0]"
            // Last value in the array is "values[values.Length - 1]"

            // Example of using a for-loop to double all elements of an array
            //for (int i = 0; i < values.Length; i++)
            //{
             //  values[i] = values[i] * 2;
            //}

            if (values.Length > 1)
            {
                if (values[0] > values[1])
                {
                    int temp = values[0];
                    values[0] = values[1];
                    values[1] = temp;
                }

            }

            // Simple sort call
           // i0nt[] values = { 4, 7, 2, 0 };
           // Array.Sort(values);
//            foreach (int value in values)
//            {
//                Console.Write(value);
//                Console.Write(' ');
//            }
//            Console.WriteLine();


           
        }
    }
}
