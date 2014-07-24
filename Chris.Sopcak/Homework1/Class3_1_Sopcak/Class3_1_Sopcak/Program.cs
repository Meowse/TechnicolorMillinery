using System;

namespace GettingInputDemo
{
    public class Program
    {
        public static void Main()
        {
            string name;
            int age;
            double height;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your Birthdate: ");
            age = Convert.ToInt32(Console.ReadLine());

            //Print a blank line
            Console.WriteLine();

            //Show the details you typed
            Console.WriteLine("Name is {0}.", name);
            Console.WriteLine("Age is {0}.", age);
            Console.WriteLine("Height is {0}.", height);
        }
    }
}