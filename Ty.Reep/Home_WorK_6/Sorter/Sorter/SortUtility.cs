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
            if (values.Length >1)
                {
                if (values[0] > values[1])
                    {
                        int temp = values[0];
                        values[0] = values[1];
                        values[1] = temp;
                    }
                }
            if (values.Length > 2)
            {
                int temp = values[1];
                values[1] = values[2];
                values[2] = temp;
            }
        }
    }
}
