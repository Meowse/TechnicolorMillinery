using System;
using System.Security.Policy;

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
            bool hasSorted = false;
            for (int i = 0; i < values.Length - 1; i++)
             {
                if (hasSorted == false)
                {
                    for (int k = 0; k < values.Length - 1; k++)
                    {

                            if (values[k] > values[k + 1])
                            {
                                int lesserValue = values[k];
                                int greaterValue = values[k + 1];

                                values[k] = greaterValue;
                                values[k + 1] = lesserValue;

                                hasSorted = true;
                            }
                            else
                            {
                                hasSorted = false;
                            }
                    }
                }
            }
             
        }
    }
}
