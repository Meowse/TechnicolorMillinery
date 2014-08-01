using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorter
{
    public class Sorter
    {
        public void Sort(int[] values)
        {
            // Read a value with "values[3]"
            // Write a value with "values[2] = 17"
            // Get the number of values with "values.Length"

            // First value in the array is "values[0]"
            // Last value in the array is "values[values.Length - 1]"

            int[] newArray = new int[7];
            for (int i = 0; i < values.Length; i++)
            {
                newArray[i] = values[i];
            }
            
        }
    }
}
