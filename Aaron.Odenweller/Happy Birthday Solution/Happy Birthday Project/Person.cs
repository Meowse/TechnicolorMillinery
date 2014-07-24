using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Birthday_Project
{
    public class Person
    {
        String FirstName;
        DateTime Birthdate;
        
        public void setFirstName(String FirstName)
        {
            this.FirstName = FirstName.Trim();
        }

        public String getFirstName(){
            String FirstName = this.FirstName;

                return FirstName;
        }

        public void setBirthdate(DateTime Birthdate)
        {
            this.Birthdate = Birthdate;
        }

        public DateTime getBirthdate()
        {
            DateTime Birthdate;

            Birthdate = this.Birthdate;

            return Birthdate;
        }


    }
}
