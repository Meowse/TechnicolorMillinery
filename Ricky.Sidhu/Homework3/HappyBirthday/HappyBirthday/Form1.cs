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
        String userName;
        String birthDate;
        String today;
        String time;

        public Form1()
        {



            InitializeComponent();
            {
                userName = textBox1.Text;
                birthDate = dateTimePicker.Text;
                textBox1.Text = DateTime.Now.ToString();
                today = DateTime.Today.ToString("MM/d");
                time = DateTime.Now.ToString();


                DateTime todays_dt = DateTime.Now;
                DateTime beforeNoon = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 11, 59, 59);
                DateTime beforeFive = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 16, 59, 59);
                DateTime afterFive = new DateTime(todays_dt.Year, todays_dt.Month, todays_dt.Day, 17, 0, 0);

                if (birthDate == today)
                {
                    MessageBox.Show("Happy Birthday to you!\n"
                                        + "Happy Birthday to you! You might live in a zoo!\n"
                                         + "Happy Birthday dear" + userName
                                          + "Happy Birthday to you!");
                }

                else if (todays_dt < beforeNoon)
                {
                    MessageBox.Show("Good morning\n"
                                    + "Good morning to you!");
                }

                else if (todays_dt < beforeFive)
                {
                    MessageBox.Show("Shhhhh its between between noon and five I'm on my siesta");

                }

                else if (todays_dt > afterFive)
                {
                    MessageBox.Show(" Hush a by baby\n"
                                    + "on the tree top\n"
                                    + "When the wind blows\n"
                                    + "The cradel will rock\n"
                                    + "When the bough breaks\n"
                                    + "The cradle will fall\n"
                                    + "And down will fall baby\n"
                                    + "Cradle and all");
                }


            }
        }

    }
}
