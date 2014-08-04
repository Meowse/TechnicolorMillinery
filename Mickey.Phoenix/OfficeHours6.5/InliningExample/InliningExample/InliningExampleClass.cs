using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InliningExample
{
    public class InliningExampleClass
    {
        public void SomeFunction(string someArg)
        {
            int total = 0;
            int length = someArg.Length;
            for (int i = 0; i < someArg.Length; i++)
            {
                char nextChar = someArg[i];
                if (char.IsDigit(nextChar))
                {
                    int value = int.Parse(nextChar.ToString()) * i;
                    total = total + value;
                }
            }
            Console.WriteLine("Total for {0} is {1}", someArg, total);
        }
    }
}
