namespace Sorter
{
    public class SortUtility
    {
        public void Sort(int[] values)
        {
            // Hints: Look at 1st card and secord card. If they're in order, look at 3rd card. If not, swap 1st and second.


            for (int i = 0; i < values.Length; i++)
            {
                //if 1st card is greater than 2nd card, switch places
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
