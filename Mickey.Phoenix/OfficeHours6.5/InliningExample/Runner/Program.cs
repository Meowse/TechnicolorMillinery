using System;
using InliningExample;

namespace Runner
{
    class Program
    {
        static void Main()
        {
            var inliningExample = new InliningExampleClass();

            string input = Console.ReadLine();
            while (input != "exit")
            {
                inliningExample.SomeFunction(input);
                input = Console.ReadLine();
            }
        }
    }
}
