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
                DateTime birthday_dt = ConvertDate(your_birthday_textbox.Text, "MM/dd/yyyy");

                DateTime todays_dt = DateTime.Now;
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

        public static DateTime ConvertDate(string date, string pattern)
        {
            MessageBox.Show("pattern " + pattern);
            DateTime retval = DateTime.MinValue;

            if (System.DateTime.TryParseExact(date, pattern, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out retval))
                return retval;

            // Could not convert date..
            return DateTime.MinValue;
        }
    }
}
