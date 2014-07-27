using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyBirthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Make this global so everyone can see it when it is created in monthCalendar1_DateChanged()
        

        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Puts the selected date into the label: SelectedDate
            SelectedDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            String theSelectedDate = monthCalendar1.SelectionRange.Start.ToShortDateString();

            // retreive and store the entered name
            String EnteredName = NametextBox.Text;
        
            // find the month, day and year from the enterd date
            var birthDateString = theSelectedDate.Split(new[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);
            String thebirthMonth   = birthDateString[0];
            String thebirthDay     = birthDateString[1];
            String thebirthYear    = birthDateString[2];

            //Create todays Date and All of its parts
            DateTime TodayDateTime = DateTime.Now;
            String TodaysMonth = TodayDateTime.Month.ToString();
            String TodaysDay = TodayDateTime.Day.ToString();
            String TodaysHour = TodayDateTime.Hour.ToString();

            int Noon = 12;
            int Evening = 17; //millatary time 5PM is 12 noon plus 5 hours

            //Create song variables and load them with mirth
            String BirthdaySong = "Happy Birthday to you\nHappy Birthday to you\nHappy Birthday to you\n";
            BirthdaySong += "Happy Birthday dear " + EnteredName + "\nHappy Birthday to you";

            String MorningSong = "Its early in the morning\nand the birds are just getting up\n";
            MorningSong += "go get some coffee " + EnteredName + "\n";
            MorningSong += "and enjoy another day!";

            String SeistaSong = "It time for a nap " + EnteredName + "\n";
            SeistaSong += "go home and wake me when it is 5 PM\n";

            String EveningSong = "It getting dark " + EnteredName + "\n";
            EveningSong += "You better get inside before the zombies get you!\n";
            EveningSong += "and if you are still alive have a nice sleep\n";


            if (thebirthMonth == TodaysMonth && thebirthDay == TodaysDay)
            {
                // if today is birthday (month & day are today, display Happy birthday song message box
                MessageBox.Show(BirthdaySong);
            }
            else
            {
                if (Convert.ToInt32(TodaysHour) < Noon)
                {
                    // if today is not birthday but morning display good morning into  message box
                    MessageBox.Show(MorningSong);
                }

                if (Convert.ToInt32(TodaysHour) < Evening)
                {
                    // if today is not birthday but noon to 5pm display is taking a siesta into message box
                    MessageBox.Show(SeistaSong);
                }
                if (Convert.ToInt32(TodaysHour) > Evening)
                {
                    // if today is not birthday but after 5PM then display lullaby into message box
                    MessageBox.Show(EveningSong);
                }
            }
       }

        //------------------ old code home -----------------------------
        private void label1_Click(object sender, EventArgs e)
        {
            //This should not be here but if I remove it everything explodes
        }
    }
}
