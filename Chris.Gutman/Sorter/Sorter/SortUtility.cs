namespace Sorter
{
    public class SortUtility
    {
        public void Sort(int[] values)
        {
            bool sortagain = new bool();
            int tempvar = new int();
            // Read a value with "values[3]"
            // Write a value with "values[2] = 17"
            // Get the number of values with "values.Length"

            // First value in the array is "values[0]"
            // Last value in the array is "values[values.Length - 1]"

            // Example of using a for-loop to double all elements of an array
            sortagain = true;
            while (sortagain)
            {
                sortagain = false;
                for (int i = 0; i < values.Length - 1; i++)
                {
                    if (values[i] > values[i + 1])
                    {
                        tempvar = values[i + 1];
                        values[i + 1] = values[i];
                        values[i] = tempvar;
                        sortagain = true;
                    }

                }
                
            }
        }
    }
}
