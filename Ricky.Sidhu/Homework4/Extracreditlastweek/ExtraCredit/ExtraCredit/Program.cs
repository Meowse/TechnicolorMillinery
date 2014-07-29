using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age");
            String stringAge = Console.ReadLine();
            int age = Int32.Parse(stringAge);

            int powerof2 = 2;
            while (age / powerof2 > 0)
            {
                powerof2 = powerof2 * 2;

            }
            powerof2 = powerof2 / 2;

            int remainderAge = age;
            string binaryAge = "";
            while (powerof2 > 0)
            {
                if (remainderAge / powerof2 > 0)
                {
                    binaryAge = binaryAge + "1";
                    remainderAge = remainderAge - powerof2;

                }
                else
                {
                    binaryAge = binaryAge + "0";
                }
                powerof2 = powerof2 / 2;
            }
            Console.WriteLine("Your age in binary is" + binaryAge);
            Console.ReadKey();

        }

    }

}