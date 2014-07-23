using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3_Problem_2
{
    public partial class Form1 : Form
    {
        String userName;
        String birthDate;
        String today;
        String time;

        public Form1()
        {
            InitializeComponent();
        }

        private void birthdayBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) { }


        private void Form1_Load(object sender, EventArgs e)
        {
            userName = nameBox.Text;
            birthDate = birthdayBox1.Text;
            dateLabel.Text = DateTime.Now.ToString();
            today = DateTime.Today.ToString("MM/d");
            time = DateTime.Now.ToString();

            //Get Today's Date
            DateTime todays_dt = DateTime.Now;
            //  Get times of day
            DateTime beforeNoon = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 11, 59, 59);
            DateTime beforeFive = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 16, 59, 59);
            DateTime afterFive = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 17, 0, 0);

            if (birthDate == today)
            {
                MessageBox.Show("Happy birthday to you!\n"
                                    + "Happy birthday to you!\n"
                                       + "Happy birthday dear " + userName
                                        + " Happy birthday to you!");
            }
            else if (todays_dt < beforeNoon )
            {
                MessageBox.Show("Good morning to you!");
            }
            else if (todays_dt < beforeFive )
            {
                MessageBox.Show("I'm on my siesta between noon and 5");
            }
            else if (todays_dt > afterFive)
            {
                MessageBox.Show("Good night!");
            }
        }
    }
}
