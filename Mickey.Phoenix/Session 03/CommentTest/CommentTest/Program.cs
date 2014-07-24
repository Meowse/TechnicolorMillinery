using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // */ Console.WriteLine("Something"); // */

            Console.WriteLine("Hello"); // Comment /* goes here; Console.WriteLine(“Goodbye”);
            Console.WriteLine("Mickey thinks this won’t print");  /* and the rest
            of the comment */


            Console.WriteLine("Hello"); /* goes here; Console.WriteLine(“Goodbye”);
            // */
            Console.WriteLine("Mickey thinks this will print");  /* and the rest
            of the comment */

            Console.ReadKey();
        }
    }
}
