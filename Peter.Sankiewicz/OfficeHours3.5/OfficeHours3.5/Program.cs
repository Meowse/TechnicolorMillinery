using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeHours3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 in binary should be: 0, and is: "
                 + GetAsBinary(0));
            Console.WriteLine("1 in binary should be: 1, and is: "
                 + GetAsBinary(1));
            Console.WriteLine("4 in binary should be: 100, and is: "
                 + GetAsBinary(4));
            Console.WriteLine("13 in binary should be: 1101, and is: "
                 + GetAsBinary(13));
            Console.WriteLine("27 in binary should be: 11011, and is: "
                 + GetAsBinary(27));
            Console.WriteLine("31 in binary should be: 11111, and is: "
                 + GetAsBinary(31)); 
            Console.WriteLine("32 in binary should be: 100000, and is: "
                 + GetAsBinary(32));
            Console.WriteLine("33 in binary should be: 100001, and is: "
                 + GetAsBinary(33));
            Console.WriteLine("\nPress Any Key to Continue...");
            Console.ReadKey();
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

        // Converst a decimal value to a binary value (represented as a string),
        // given the largest power of 2 that the decimal value contains.
        private static string ConvertToBinary(int decimalValue,int powerOf2)
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
                    binaryValue = binaryValue + 0;
                }
                powerOf2 = powerOf2 / 2;
            }
            return binaryValue;
        }

        private static int GetLargestPowerOf2(int decimalValue)
        {
            int powerOf2 = 1;
            while (powerOf2 <= decimalValue)
            {
                powerOf2 = powerOf2 * 2;
            }
            return powerOf2 = powerOf2 / 2;
        }
    }
}
