using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
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

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (name_textbox.Text == "")
            {
                MessageBox.Show("Please enter a name, required field.");
            }

            else if (your_birthday_textbox.Text == "")
            {
                MessageBox.Show("Please enter a date, pick a date from the Date Picker, required field");
            }

            if (your_birthday_textbox.Text != null)
            {
                // If you have a specific format for the string, you should use the other method:                         
                // "d" stands for the short date pattern (see MSDN for more info) and null specifies that the current culture should be used for parsing the string.
                //DateTime birthday_dt = DateTime.ParseExact(your_birthday_textbox.Text, "d", null);
               // MessageBox.Show("Birthday Date " + birthday_dt);

                DateTime birthday_dt = ConvertDate(your_birthday_textbox.Text, "MM/dd/yyyy");

                //string[] bday_format = { "yyyyMMdd" };
                //DateTime birthday_dt;

                //if (DateTime.TryParseExact(your_birthday_textbox.Text,
                  //                         bday_format,
                   //                        System.Globalization.CultureInfo.InvariantCulture,
                  //                         System.Globalization.DateTimeStyles.None,
                  //                         out birthday_dt))
                //{
                    //valid
               // }

                DateTime todays_dt = DateTime.Now;
                MessageBox.Show("Todays Date " + todays_dt);

                string format = "MM/dd/yyyy";    // Use this format
                string str_todays_dt = todays_dt.ToString(format);

                MessageBox.Show("Todays Date " + str_todays_dt);
                MessageBox.Show("Birthday Date " + birthday_dt);
             

                if (birthday_dt.Date > todays_dt.Date)
                {
                    // MessageBox.Show("Todays date " + dt2)
                    // MessageBox.Show("Todays date " + dt2);
                    //It's a later date
                }
                else
                {
                    //It's an earlier or equal date
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            your_birthday_textbox.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        public static DateTime ConvertDate(string in_date, string pattern)
        {
            MessageBox.Show("pattern " + pattern);
            DateTime retval = DateTime.MinValue; //Represents the smallest possible value of DateTime. This field is read-only.

            if (System.DateTime.TryParseExact(in_date, 
                pattern, 
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, 
                out retval))
                return retval;

            // Could not convert date..
            return DateTime.MinValue;
        }

        
    }
}
