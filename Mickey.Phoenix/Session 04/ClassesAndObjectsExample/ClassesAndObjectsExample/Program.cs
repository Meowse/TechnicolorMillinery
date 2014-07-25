using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndObjectsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person fred = new Person();
            fred.Rename("Fred", "Flintstone");

            Person barney = new Person();
            barney.Rename("Barney", "Rubble");

            fred.Spouse = barney;
            barney.Spouse = fred;

            Console.WriteLine("Fred's spouse's first name is: " + fred.Spouse.FirstName);
            Console.WriteLine("Barney's spouse's last name is: " + barney.Spouse.LastName);
            Console.WriteLine("Fred's spouse's spouse's spouse's spouse's spouse's last name is: "
                + fred.Spouse.Spouse.Spouse.Spouse.Spouse.LastName);

            Console.WriteLine("Fred's SSN is: " + fred.SSN);
            Console.WriteLine("Barney's SSN is: " + barney.SSN);
            Console.WriteLine("The next child born will be given SSN: " + Person.NextSocialSecurityNumber);

            Person child = new Person();
            Console.WriteLine("Their child has SSN: " + child.SSN);

            Console.ReadKey();
        }
    }
}
