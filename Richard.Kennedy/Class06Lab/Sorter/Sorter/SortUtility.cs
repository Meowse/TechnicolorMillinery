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
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = (i + 1); j < values.Length; j++)
                {
                    if (values[i] > values[j])
                    {
                        int temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                    }
                }
            }
        }
    }
}