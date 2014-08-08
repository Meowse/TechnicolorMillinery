using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Session6_Sort_Example_Project
{
    public class Sorter
    {
        static int count;

        public void Sort(int[] values)
        {
           
            //int[] newArray = new int[7];  //[7] is the SIZE of the Array.  NOT the index
            do
            {
                count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                count = i;
                if (count != values.Length - 1)
                {
                
                    if (values[i] > values[i + 1])
                    {
                        Swap(values, i, i + 1);
                    }
              
                }
            }
                
            } while (FinishedSorting(values) != true);
        }

        private void Swap(int[] values, int indexLeft, int indexRight)
        {
            var temp = values[indexRight];
            values[indexRight] = values[indexLeft];
            values[indexLeft] = temp;
        }

        private bool FinishedSorting(int[] values)
        {

            for (int i = 0; i < values.Length; i++)
            {
                if (i == values.Length - 1)
                {
                    return true;
                }
                if (values[i + 1] < values[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
