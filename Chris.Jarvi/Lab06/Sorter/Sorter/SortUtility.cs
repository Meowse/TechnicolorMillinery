using System;

namespace Sorter
{
    public class SortUtility
    {
        public void Sort(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
        }
    }
}
