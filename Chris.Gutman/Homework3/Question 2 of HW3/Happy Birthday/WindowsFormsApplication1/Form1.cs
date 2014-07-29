using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DateTime NoonToday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 12, 0, 0);
        private DateTime FivepmToday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 17, 0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Bye(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calculate(object sender, EventArgs e)
        {

/* Use visual studios namespace for regular expressions this time instead of attempting to
   add a reference to VB script and use that convoluted set up used on last homework problem.... */

            string mystring = @"(((\s+)?\d{0,2}(\s+)?[/\-]){2}(\s+)?(\d\d)?\d\d)" +
                @"|((Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|nov|Dec)(\s+)(\d+),?(\s+)(\d\d)?\d\d)";
            
            Regex re = new Regex(mystring);
            RegexOptions reoptions = new RegexOptions();
            reoptions = RegexOptions.Singleline | RegexOptions.IgnoreCase;
            Match rematch = re.Match(BirthdayBox.Text);
            
/* this should place a validated date in mystring. If it is populated, use the DateTime facility to implement the rest of the 
      comparisons asked for in the homework*/

            mystring = rematch.Value.ToString();    

/* If there was a valid birth day found ... */

            if(mystring != "") 
            {
                DateTime birthdate = DateTime.Parse(mystring);
                DateTime birthday = new DateTime(DateTime.Today.Year, birthdate.Month, birthdate.Day);
                DateTime DateToday = DateTime.Today;
                int answer = DateTime.Compare(birthday, DateToday);
                
/*     If today is the user's birthday, answer will == 0     */
                
                if (answer == 0)
                {
                    MessageBox.Show("Happy Birthday to you" +
                                        "\nHappy Birthday to you" +
                                        "\nHappy Birthday dear" + NameBox.Text +
                                        "\nHappy Birthday to you!!");
                }
                else if (DateTime.Compare(DateTime.Now, NoonToday)<0)
                {
                    MessageBox.Show("Good Morning to you, good morning to you....");

                }
                else if (DateTime.Compare(DateTime.Now, FivepmToday) > 0)
                {
                    MessageBox.Show("Lullaby, lullaby, and good night ... ");
                }
                else if ((DateTime.Compare(DateTime.Now, FivepmToday) <= 0) & (DateTime.Compare(DateTime.Now, NoonToday) >= 0)) 
                {
                    MessageBox.Show("Nice of you to join us today.  Unfortunately, we are taking a siesta...");
                }


            }

/*    Here, we were unable to interpret the user's entry for their birthday, ask them to re-enter... */

            else
            {
                MessageBox.Show(NameBox.Text + ", please enter your birthdate on earth");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
