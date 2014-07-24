using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyBirthdayKiddingExtraCredit
{
    public partial class Form1 : Form
    {
        public Form1()
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
                    string str_age_binary = GetIntBinaryString(age);
                    MessageBox.Show("Your age is " + age + "\n" +
                                    "Your age in Binary is " + str_age_binary);

                    string str_age = age.ToString();
                    //MessageBox.Show("Age string " + str_age);
          
                    // Sing Happy Birthday the number times of their age
                    SingHappyBirthday(age, str_age);
                    //int i=0;
                    //while(i <= age)
                    //{
                    //    MessageBox.Show("Happy Birthday to you! " + str_age + " times\n" +
                    //                 "Happy Birthday to you!\n" +
                    //                 "Happy Birthday Dear " + name_textbox.Text + "\n" +
                    //                 "Happy Birthday to youuuuuuuuuuu!");
                    //    i++;
                    //}    //  End of While
                     
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

        
        /* The method receives a normal integer, and then loops over each of the 32 bit positions.
          At the same time, it writes zeros and ones in reverse order. This results in standard results. 
         The char array is the most efficient structure here.
         */

        static string GetIntBinaryString(int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }  //  End of method GetIntBinaryString

        void SingHappyBirthday(int age, string str_age)
        {
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
        }       //  End of method SingHappyBirthday
    }
}
