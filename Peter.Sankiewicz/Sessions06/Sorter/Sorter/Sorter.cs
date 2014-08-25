using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    public class Sorter
    {
        public void Sort(int[] values)
        {
            //Read a value with value[3]
            //Write a value with values[2] = 17
            //Get the number of values with values.length
            Console.WriteLine(values[values.Length - 1]);
            Console.ReadKey();

            int[] newArray = new int[7];
            for (int i = 0; i < values.Length; i++)
            {
                newArray[i] = values[i];
            }
            Array.Copy
        }

    }
}
