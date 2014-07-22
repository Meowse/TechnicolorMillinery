using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Happy_Birthday_Project
{
     class Program

       {

         public static bool stop = false;

         public static void stopInvoked(string userInput){
         
             if(userInput.Trim().ToLower() == "stop"){
                 stop = true;
             }
       
     }
 
        public static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            String tryDate;
            DateTime validDate;
            String userNametemp = "";

            String currentTime = Convert.ToString(DateTime.Now);

            Console.WriteLine("Hello there! To end the program, simply type \"Stop\" or close the window. ");
            CultureInfo enUS = new CultureInfo("en-US");           
            do
            {
                //while statement inside of a do while statement
                while (userNametemp == "" || userNametemp == null)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("What's your name?");
                    userNametemp = Console.ReadLine();

                    if (userNametemp == null || userNametemp == "")
                    {
                        Console.WriteLine("You must enter a value");
                    }
                    else if (userNametemp.Trim().ToLower() == "stop")
                    {
                        stopInvoked(userNametemp);
                    }

                    else{
                        userNametemp = userNametemp.Trim();
                        
                    }

                } // end while Name

                //while statement inside of a do while statement
                while (stop == false)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Hi " + userNametemp + ". Please enter your birthday.  You must enter your birthday in the following format: MM/DD/YYYY");
                    tryDate = Console.ReadLine();

                    stopInvoked(tryDate);

                    if (DateTime.TryParseExact(tryDate, "MM/dd/yyyy", CultureInfo.InvariantCulture,
                               DateTimeStyles.None, out validDate) && stop == false)
                    {
                        Person aPerson = new Person();
                        aPerson.setFirstName(userNametemp);
                        aPerson.setBirthdate(validDate.Date);

                        Greeting aGreeting = new Greeting(validDate, aPerson.getFirstName());
                        Console.WriteLine(System.Environment.NewLine + "Hi " + aPerson.getFirstName() + ". Your birthday is " + aPerson.getBirthdate().Month + "/" + aPerson.getBirthdate().Day + "/" + aPerson.getBirthdate().Year);
                        Console.WriteLine(aGreeting.greeting);
                        Console.WriteLine(System.Environment.NewLine + System.Environment.NewLine +
                                           "This game was fun, " + userNametemp + "."+ System.Environment.NewLine +
                                           "Get your friends and come back later! Bye bye!");
                        stop = true;
                        Console.ReadKey();
                    } // end if

                    else if (stop == true)
                    {
                        Console.WriteLine("Press any key to exit");
                        Console.ReadLine();
                    } // end else if

                    else
                    {
                        Console.WriteLine("'{0}' is not in an acceptable format.", tryDate);
                        
                    }// end else

                } // end while Birthdate

            } while (stop == false); // end do while statement
            

        }
    }
}
