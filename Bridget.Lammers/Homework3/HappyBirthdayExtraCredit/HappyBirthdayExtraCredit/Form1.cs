using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyBirthdayExtraCredit
{
    public partial class month_calendar : Form
    {
        public month_calendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            your_birthday_textbox.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void click_for_surprise_button_Click(object sender, EventArgs e)
        {
            if (name_textbox.Text == "")
            {
                MessageBox.Show("Please enter a name, required field.");
            }

            else if (your_birthday_textbox.Text == "")
            {
                MessageBox.Show("Please enter a date, pick a date from the Date Picker, required field");
            } //  End IF

            if (your_birthday_textbox.Text != null)
            {
                // Converts the string representation of a date and time to its DateTime equivalent.  
                DateTime birthday_dt = DateTime.Parse(your_birthday_textbox.Text);
                
                //  Get Todays Date
                DateTime todays_dt = DateTime.Now;

                //  Get times of day
                DateTime beforeNoon = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 11, 59, 59);
                DateTime beforeFive = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 16, 59, 59);
                DateTime afterFive = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 17, 0, 0);


                //  Get todays date
               // MessageBox.Show("Birthday " + birthday_dt + "\n" +
                 //               "Today" + todays_dt + "\n" +
                //                "Before Noon" + beforeNoon + "\n" +
                //                "Before Five" + beforeFive + "\n" +
                 //               "After Five" + afterFive);


               
                //  Is it their birthday
                if (birthday_dt.Month == todays_dt.Month &&
                    birthday_dt.Day == todays_dt.Day)
                {
                    int age = todays_dt.Year - birthday_dt.Year;
                    string str_age = age.ToString();
                    //MessageBox.Show("Age string " + str_age);
          
                    // Sing Happy Birthday the number times of their age
                    int i=0;
                    while(i <= age)
                    {
                        MessageBox.Show("Happy Birthday to you! " + str_age + " times\n" +
                                     "Happy Birthday to you!\n" +
                                     "Happy Birthday Dear " + name_textbox.Text + "\n" +
                                     "Happy Birthday to youuuuuuuuuuu!");
                        i++;
                    }    //  End of While
                     
                }
                
                // Not birthday, check before noon
                else if (todays_dt < beforeNoon)
                {
                    MessageBox.Show("Good morning " + name_textbox.Text);
                }
                
                //  Cjecl before 5:00
                else if (todays_dt < beforeFive)
                {
                    MessageBox.Show("Time for Happy Hour, margarita and nachos! " + name_textbox.Text);
                }

                //  Default after 5:00
                else
                {
                    MessageBox.Show("Good night and sleep well! " + name_textbox.Text);
                }
            }   // End IF
        }       // End enter_button_Click
    }           //  End of Class
}               //  End of namespace
