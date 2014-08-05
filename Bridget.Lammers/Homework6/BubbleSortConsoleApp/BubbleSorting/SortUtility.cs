using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    public class SortUtility
    {

         Console.Write("\nProgram for sorting using Bubble Sort Algorithm");

            Console.Write("\n\nEnter the total number of elements: ");

            int max = Convert.ToInt32(Console.ReadLine());



            int[] numarr = new int[max];



            for (int i = 0; i < max; i++)
            {

                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");

                numarr[i] = Convert.ToInt32(Console.ReadLine());

            }



            Console.Write("Input int array   : ");

            for (int k = 0; k < max; k++)

                Console.Write(numarr[k] + " ");

            Console.Write("\n");



            for (int i = 1; i < max; i++)
            {

                for (int j = 0; j < max - i; j++)
                {

                    if (numarr[j] > numarr[j + 1])
                    {

                        int temp = numarr[j];

                        numarr[j] = numarr[j + 1];

                        numarr[j + 1] = temp;

                    }

                }

                Console.Write("Iteration " + i.ToString() + ": ");

                for (int k = 0; k < max; k++)

                    Console.Write(numarr[k] + " ");

                Console.Write("\n");



            }



            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");

            for (int i = 0; i < max; i++)
            {

                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");

                Console.Write(numarr[i]);

                Console.Write("\n");

            }

            return 0;
    }
}
