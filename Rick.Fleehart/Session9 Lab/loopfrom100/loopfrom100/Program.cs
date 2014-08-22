using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace loopfrom100
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
            Console.ReadLine();
        }

        public static void Display()
        {
            for ( int i=100; i >=0; i-=7)
            {
                Console.WriteLine(" i is " + i );
            }
            
        }
    }
}
