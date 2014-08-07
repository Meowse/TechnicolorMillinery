namespace Sorter
{
    public class SortUtility
    {
        public void Sort(int[] values)
        {
            // Really basic and buggy
            for (int i = 0; i < values.Length; i++)
            {
                if (values.Length > 1)
                {
                    if (values[0] > values[1])
                    {
                        int swapper = values[0];
                        values[0] = values[1];
                        values[1] = swapper;
                    }

                }
            }



        }
    }
}
