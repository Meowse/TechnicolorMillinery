using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyBirthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set variables
            int Noon = 12;
            int Evening = 17;

            // Get user's given name from the form
            string givenName = textBox1.Text;
            // Check for a valid name
            validateName(givenName);

            // Get user's birthday from the form
            string enteredDate = textBox2.Text;
            // Check for a valid date
            validateDate(enteredDate);

            // Get user's birth month, day, and year
            var birthDateString = enteredDate.Split(new[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);
            String birthMonth   = birthDateString[0];
            String birthDay     = birthDateString[1];
            String birthYear    = birthDateString[2];

            // Get current month, day, year, hour, and minute
            DateTime currentDateTime = DateTime.Now;
            // Get Current Month
            string currentMonth = currentDateTime.Month.ToString();
            // Get Current Day
            string currentDay = currentDateTime.Day.ToString();
            // Get Current Year
            string currentYear = currentDateTime.Year.ToString();
            // Get Current Hour
            string currentHour = currentDateTime.Hour.ToString();
            // Get Current Minute
            string currentMinute = currentDateTime.Minute.ToString();

            // Define songs
            string birthdaySong = "Happy Birthday to You,\n" +
            "Happy Birthday to You,\n" +
            "Happy Birthday Dear " + givenName + "," +
            "\nHappy Birthday to You.\n\n" +
            "From good friends and true,\n" +
            "From old friends and new,\n" +
            "May good luck go with you,\n" +
            "And happiness too.";
            string goodMorningSong = "Good morning to you,\n" +
            "Good morning to you,\n" +
            "Our day is beginning,\n" +
            "There's so much to do.\n" +
            "So good morning, good morning, good morning to you!";
            string siestaSong = "Hush! It's my siesta.";
            string lullabySong = "Twinkle, twinkle, little star\n" +
            "How I wonder what you are!\n" +
            "Up above the world so high\n" +
            "Like a diamond in the sky.\n" +
            "Twinkle, twinkle, little star\n" +
            "How I wonder what you are!";

            if (currentMonth == birthMonth && currentDay == birthDay)
            {
                int age = Convert.ToInt32(currentYear) - Convert.ToInt32(birthYear);
                string ageString = age.ToString();
                string onesDigit = ageString.Substring(ageString.Length - 1);
                int caseSwitch = Convert.ToInt32(onesDigit);
                string ordinalIndicator;
                switch (caseSwitch)
                {
                    case 0:
                        ordinalIndicator = "th";
                        break;
                    case 1:
                        ordinalIndicator = "st";
                        break;
                    case 2:
                        ordinalIndicator = "nd";
                        break;
                    case 3:
                        ordinalIndicator = "rd";
                        break;
                    default:
                        ordinalIndicator = "th";
                        break;
                }

                // Find the largest power of two for the given age
                int powerOf2 = 2;
                while (age / powerOf2 > 0)
                {
                    powerOf2 = powerOf2 * 2;
                }
                powerOf2 = powerOf2 / 2;
                // MessageBox.Show(powerOf2.ToString());

                // Calculate age in binary
                int remainderAge = age;
                string binaryAge = "";
                while (powerOf2 > 0) 
                {
                    if (remainderAge / powerOf2 > 0)
                    {
                        binaryAge = binaryAge + "1";
                        remainderAge = remainderAge - powerOf2;
                    }
                    else
                    {
                        binaryAge = binaryAge + "0";
                    }
                    powerOf2 = powerOf2 / 2;
                }

                // MessageBox.Show(binaryAge);

                birthdaySong = "Happy  " + ageString + ordinalIndicator + " Birthday!\n" +
                                "(That's " + binaryAge + " in binary)\n\n" + birthdaySong;
                MessageBox.Show(birthdaySong);
            }
            else
            {
                if (Convert.ToInt32(currentHour) < Noon)
                {
                    MessageBox.Show(goodMorningSong);
                }
                if (Convert.ToInt32(currentHour) >= Noon && Convert.ToInt32(currentHour) <= Evening)
                {
                    MessageBox.Show(siestaSong);
                }
                if (Convert.ToInt32(currentHour) >= Evening)
                {
                    MessageBox.Show(lullabySong);
                }
            }
        }

/*        private void largestPowerOf2(int age)
        {
            int powerOf2 = 2;
            while (age / powerOf2 > 0)
            {
                powerOf2 = powerOf2 * 2;
            }
            powerOf2 = powerOf2 / 2;
            return powerOf2;
        }
 * */

        private bool validateName(string givenName)
        {
            if (givenName.Trim() == "")
            {
                MessageBox.Show("Please enter your given name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateDate(string enteredDate)
        {
            DateTime temp;
            if (DateTime.TryParse(enteredDate, out temp))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter your birth date m/d/yyyy."); 
                return false;
            }
        }
    }
}
