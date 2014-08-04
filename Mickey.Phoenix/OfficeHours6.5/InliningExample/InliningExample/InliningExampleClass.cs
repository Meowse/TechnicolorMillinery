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
            for (int i = 0; i < someArg.Length; i++)
            {
                char nextChar = someArg[i];
                if (char.IsDigit(nextChar))
                {
                    int value = int.Parse(nextChar.ToString()) * (i - someArg.Length);
                    total = total + value;

                    // int value = int.Parse(nextChar.ToString()) * (i - length);
                    // total = total + value;
                    //      becomes
                    // total = total + int.Parse(nextChar.ToString()) * (i - length);
                    //      if we inline the variable "value"
                }
            }
            Console.WriteLine("Total for {0} is {1}", someArg, total);
        }

        public bool IsGoodJob(string someArg)
        {
            if (string.IsNullOrEmpty(someArg))
            {
                return false;
            }

            bool shouldSkip = ShouldSkip(someArg);
            bool isGoodJob = someArg.StartsWith("good") && someArg.EndsWith("job");
            return !shouldSkip && isGoodJob;
        }

        private static bool ShouldSkip(string someArg)
        {
            return someArg.Contains("skip") || someArg.Contains("avoid") || someArg.Contains("nope");
        }
    }
}
