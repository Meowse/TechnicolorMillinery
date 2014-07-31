using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariableScope
{
    class Program
    {

        static void Main(string[] args)
        {
            // Local variables are not in scope before they are declared.
            // Console.WriteLine("FirstVar is: " + firstVar);

            int firstVar;
            firstVar = 3;

            {
                float float1 = (float)1.234567891011;
                float float2 = (float)1.234567891012;
                Console.WriteLine("float1 == float2? " + (float1 == float2));
                double secondVar = 173.3113519590138509138;
                Console.WriteLine("I can make a new scope just for the heck of it: " + secondVar);
            }

            if (firstVar == 3)
            {
                string secondVar = "Fred";
                Console.WriteLine("SecondVar is: " + secondVar);

                // secondVar "goes out of scope" (stops existing) at the end of the
                // BLOCK in which it is declared.  And curly braces define a new block.
            }
            else
            {
                // This "secondVar" is completely separate from the one in the "if"-clause.
                int secondVar = 17;
                Console.WriteLine("SecondVar is: " + secondVar);
            }

            // secondVar no longer exists -- it was declared inside a block that has ended
            // Console.WriteLine("SecondVar is: " + secondVar);

            // Local variables stay in scope until the end of the block they are declared in
            Console.WriteLine("firstVar is: " + firstVar);

            Console.ReadKey();
        }

        private void setMyValue(int newValue)
        {
            myIntegerInstanceVariable = newValue;
        }

        int myIntegerInstanceVariable = 17;

        private void printMyValue()
        {
            Console.WriteLine("myInstanceVariable is " + myIntegerInstanceVariable);
        }
    }
}
