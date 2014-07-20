using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethodsExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal numbers are in decimal -- each "place value" is
            // 10 times greater than the one to its right.  So the "3"
            // in "34" represents a number 10 times larger than the "3"
            // in "3".
            // Binary is a representation for numbers where each "place value"
            // is 2 times larger than the one to its right.  So the "1"
            // in "10" represents a number that is twice as big as the "1" 
            // in "1".
            // "100" -- that would mean "one 4, zero 2's, zero 1's".
            // "101" -- that would mean "one 4, zero 2's, one 1"
            // "13" -- in binary, that's (16)(8)(4)(2)(1)
            //                             0  1
            //  13 - 8: 5
            //                                   1
            //  5 - 4: 1
            //                                      0  1
            //  1 - 1: 0
            // Binary representation for 13 is: 01101
            // 00000099 == 99
            // 00000001101 == 1101
            // 1101
            // 1 + 4 + 8 = 13
            // 27 == (32)(16)(8)(4)(2)(1)
            //             1
            // 27 - 16 = 11
            //                1
            // 11 - 8 = 3
            //                   0  1  1
            // 27 = 11011
            // 1 + 2 + 8 + 16 = 27

            // Convert a number to binary
            // Steps:
            // 1) Find the largest power of 2 that is smaller than or equal
            //    to the number.
            // 2) Subtract that power of 2 from the number, and then
            //    (if there's anything left) find the next smaller power of
            //    2 and subtract it from the remainder, until you get to 0.
            //
            // Example: the number is 6.
            // The largest power of 2 that is smaller than or equal to the 
            // number is "4".
            // Subtract 4 from 6, and you get 2.
            // Divide 4 in half, and you get 2.
            // Subtract 2 from 2, and you get 0.  The answer is
            // "one 4, and one 2, and zero 1's", or "110", which is the
            // binary representation for 6.

            Console.WriteLine("0 in binary should be 0, is: "
                 + GetAsBinary(0));
            Console.WriteLine("1 in binary should be 1, is: "
                 + GetAsBinary(1));
            Console.WriteLine("4 in binary should be 100, is: "
                 + GetAsBinary(4));
            Console.WriteLine("13 in binary should be 1101, is: "
                 + GetAsBinary(13));
            Console.WriteLine("27 in binary should be 11011, is: "
                 + GetAsBinary(27));
            Console.WriteLine("31 in binary should be 11111, is: "
                 + GetAsBinary(31));
            Console.WriteLine("32 in binary should be 100000, is: "
                 + GetAsBinary(32));
            Console.WriteLine("33 in binary should be 100001, is: "
                 + GetAsBinary(33));

            Console.ReadKey();
        }

        private static string GetAsBinary(int decimalValue) {
            if (decimalValue == 0)
            {
                return "0";
            }

            int powerOf2 = 1;
            while (powerOf2 <= decimalValue)
            {
                powerOf2 = powerOf2 * 2;
            }
            powerOf2 = powerOf2 / 2;

            // The string of "1"s and "0"s that represents the number in binary
            string binaryValue = "";

            while (powerOf2 > 0)
            {
                // Either the remaining decimalValue contains the current power
                // of 2, or it doesn't.
                // If it does contain the current power of 2:
                //      subtract it from the decimal number
                //      add a "1" to binaryValue to record that it contained
                //          this power of 2
                // If it doesn't contain the current power of 2:
                //      add a "0" to binaryValue to record that it did not
                //      contain this power of 2
                if (decimalValue >= powerOf2)
                {
                    decimalValue = decimalValue - powerOf2;
                    binaryValue = binaryValue + "1";
                }
                else
                {
                    binaryValue = binaryValue + "0";
                }
                powerOf2 = powerOf2 / 2;
            }

            return binaryValue;
        }

        // In class, talk about:
        //  "intentional programming"
        //  top-down design
        //  hierarchical decomposition
    }
}
