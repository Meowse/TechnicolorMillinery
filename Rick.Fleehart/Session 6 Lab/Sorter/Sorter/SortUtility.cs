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

            // Bubble sort
            // compare element 1 with element 2. if element 1 is greater swap them

            int tempInt = 0;

            for (int secondCounter = 1; secondCounter < values.Length; secondCounter++)
            { 
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] > values[secondCounter]) //swap the two values below
                    {
                        tempInt                 = values[secondCounter]; //save the second number
                        values[secondCounter]   = values[i]; //replace the second with the first
                        values[i]               = tempInt; // replace the first with the second that was stored in tempInt

                    }
               
                }
            }
        }
    }
}
