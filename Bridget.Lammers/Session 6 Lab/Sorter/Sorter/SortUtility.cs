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

            for (int i = 0; i < values.Length; i++)
            {
                 
                if (values[i] > values[i + 1]) //unhandled out of bounds error here
                for (int ndx = i+1; ndx < values.Length; ndx++)
                {
                    int tempInt = values[i];
                    values[i] = values[i + 1];
                    values[i + 1] = tempInt;

                    if (values[i] > values[ndx])
                    {
                        int tempInt = values[i];
                        values[i] = values[ndx];
                        values[ndx] = tempInt;
                    }
                }
            }
        }
    }
}
