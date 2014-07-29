using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Part_3__HW3_SIAKEC_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            happyBirthday();
            Console.WriteLine("What is your age? ");
            String input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            Console.WriteLine("Your age in binary is: " + GetAsBinary(age));
            Console.ReadKey();
        }

        private static void happyBirthday()
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear user!");
            Console.WriteLine("Happy birthday to you!!");
        }

        private static string GetAsBinary(int decimalValue)
        {
            if (decimalValue == 0)
            {
                return "0";
            }
            int largestPowerOf2 = GetLargestPowerOf2(decimalValue);

            return ConvertToBinary(decimalValue, largestPowerOf2);
        }


        private static int GetLargestPowerOf2(int decimalValue)
        {
            int powerOf2 = 1;
            while (powerOf2 <= decimalValue)
            {
                powerOf2 = powerOf2*2;
            }
            return powerOf2/2;
        }

        // Convert a decimal value to a binary value (represented as a 
        // string), given the largest power of 2 that the decimal value
        // contains.
        private static string ConvertToBinary(int decimalValue, int powerOf2)
        {
            string binaryValue = "";

            while (powerOf2 > 0)
            {
                if (decimalValue >= powerOf2)
                {
                    binaryValue = binaryValue + "1";
                    decimalValue = decimalValue - powerOf2;
                }
                else
                {
                    binaryValue = binaryValue + "0";
                }
                powerOf2 = powerOf2/2;
            }

            return binaryValue;
        }
    }
}
