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
            //1. find the power of two that is smaller or equal to the number
            //2. subtract that power of 2 from the number, and then (if there is nothing left) 
            //   find the next smaller power of 2 and subtract it from the remainder, until you get 0

            // is n larger than x
            int powerOf2 = 1;
            while (powerOf2 <= decimalValue)
            {
                powerOf2 = powerOf2*2; 
            }
            powerOf2 = powerOf2/2;

            string binaryValue = "";
            
            while (powerOf2 > 0)
            {
                //either the remaining decimalValue contains the current power of 2, or it doesn't.
                //if it does contain the power of 2:
                //    subtract it from the decimal number
                //    add a "1" to binaryValue to record that it contained this power of 2
                //if it doesn't contain the current power of two
                //    find the next power of two
                //    add a 0 binaryValue to record that it did not contain this power of 2
                if (decimalValue >= powerOf2)
                {
                    decimalValue = decimalValue - powerOf2;
                    binaryValue = binaryValue + "1";
                }
                else
                {
                    binaryValue = binaryValue + 0;
                }
                powerOf2 = powerOf2/2;
            }
            return binaryValue;
        }
    }
}
