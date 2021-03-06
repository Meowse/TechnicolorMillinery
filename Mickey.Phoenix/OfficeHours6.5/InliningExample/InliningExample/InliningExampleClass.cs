﻿using System;

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
                    int value = int.Parse(nextChar.ToString()) * (someArg.Length - i);
                    total = total + value;

                    // int value = int.Parse(nextChar.ToString()) * (SomeArg.length - i);
                    // total = total + value;
                    //      becomes
                    // total = total + int.Parse(nextChar.ToString()) * (SomeArg.length - i);
                    //      if we inline the variable "value"
                }
            }
            Console.WriteLine("Total for {0} is {1}", someArg, total);
        }

        public bool IsGoodJob(string someArg)
        {
            if (string.IsNullOrEmpty(someArg) || ShouldSkip(someArg))
            {
                return false;
            }

            return someArg.StartsWith("good") && someArg.EndsWith("job");
        }

        private static bool ShouldSkip(string someArg)
        {
            return someArg.Contains("skip") || someArg.Contains("avoid") || someArg.Contains("nope");
        }
    }
}
