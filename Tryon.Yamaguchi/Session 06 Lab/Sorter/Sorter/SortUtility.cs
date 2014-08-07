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

            int temp = 0;

            for (int i = 0; i < values.Length; i++)
            {

                for (int j = 0; j < values.Length - 1; j++)
                {
                    
                        if (values[j] > values[j + 1])
                        {
                            temp = values[j + 1];
                            values[j + 1] = values[j];
                            values[j] = temp;
                        }
                }
            }
        }
    }
}
