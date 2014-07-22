using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Birthday_Project
{
    public class Greeting
    {
        DateTime today;
        String name;
        //DateTime usersBirthday;
        public String greeting;

        public Greeting(DateTime Birthday, String firstName)
        {
            today = DateTime.Now;
            greeting = getGreeting(today, Birthday, firstName);
            
        }

        private String getGreeting(DateTime today, DateTime usersBirthday, String firstName)
        {
            String aGreeting = "";
            this.name = firstName;
            int hour = today.Hour;

            if (today.Month.CompareTo(usersBirthday.Month) == 0 && today.Day.CompareTo(usersBirthday.Day) == 0)
            {
                aGreeting = System.Environment.NewLine + "Happy birthday to you.  Happy birthday to you." + System.Environment.NewLine + "Happy birthday dear " + name + ".  Happy birthday to you. " + System.Environment.NewLine;
            } //end if birthday check
            
            if(hour < 12){
                aGreeting += System.Environment.NewLine + "Good morning, " + name;
            }

            else if(hour <= 17 && hour >= 12){
                aGreeting += System.Environment.NewLine+ "Sorry, " + name + ". It's the afternoon!  Get back to work";
            }
            else
            {
                aGreeting += System.Environment.NewLine + "Rock-a-bye baby, in the treetop " + System.Environment.NewLine +
                              "When the wind blows, the cradle will rock" + System.Environment.NewLine +
                              "When the bough breaks, the cradle will fall " + System.Environment.NewLine +
                              "And down will come baby, cradle and all";
            }

            return aGreeting;
        } // end getGreeting
    }
}
