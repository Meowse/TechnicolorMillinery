using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2ExtraCredit
{
  public class Greeting
    {
    public String greeting = "";
    public String txtInput = "";

      public Greeting(String txtInput)
      {
          this.txtInput = txtInput;
          setGreeting(this.txtInput);
      }
             
     
        public void setGreeting(String txtInput) {

            if (txtInput.ToLower().Trim() == "mickey")
            {
                this.greeting = "teacher!";
            }

            else this.greeting = txtInput;

       } //end setName   

    }
}
