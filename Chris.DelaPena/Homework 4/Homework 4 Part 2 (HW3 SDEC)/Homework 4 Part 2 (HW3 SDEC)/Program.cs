using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_Part_2__HW3_SDEC_
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user's age
            Console.Write("How old are you?");
            String stringAge = Console.ReadLine();
            int age = Int32.Parse(stringAge);
            //print out user's age in binary using while loop

            // Find the largest power of two for the given age
            int powerOf2 = 2;
            while (age / powerOf2 > 0)
            {
                powerOf2 = powerOf2 * 2;
            }
            powerOf2 = powerOf2 / 2;
            // MessageBox.Show(powerOf2.ToString());

            // Calculate age in binary
            int remainderAge = age;
            string binaryAge = "";
            while (powerOf2 > 0)
            {
                if (remainderAge / powerOf2 > 0)
                {
                    binaryAge = binaryAge + "1";
                    remainderAge = remainderAge - powerOf2;
                }
                else
                {
                    binaryAge = binaryAge + "0";
                }
                powerOf2 = powerOf2 / 2;
            }

            // MessageBox.Show(binaryAge);
            Console.WriteLine("Your age in binary is " + binaryAge);
            Console.ReadKey();

            //Check office hours
        }
    }
}
