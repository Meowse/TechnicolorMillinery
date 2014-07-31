using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greetings_HW3
{
    public partial class IntroductionBox : Form
    {
        public IntroductionBox()
        {
            InitializeComponent();
        }

        private void GreetButton_Click(object sender, EventArgs e)
        {
            {
                String UserName = NameField.Text;

                if (UserName.Length == 0)
                {
                    MessageBox.Show("Oops, please enter your name above.");

                }
                else
                {
                    String Greeting = "Hello, " + UserName + "!";

                    GreetingLabel.Text = Greeting;
                }
                if (UserName == "Mickey")
                {
                    GreetingLabel.Text = "Hello, teacher!";
                }

            }

        }


        private void DateTime_Click(object sender, EventArgs e)
        {
            DateTime theDate;

            theDate = DateTime.Now;

            int theDay = theDate.Day;
            int theMonth = theDate.Month;
            int theYear = theDate.Year;
            int theTime = theDate.Hour;
            label4.Text = theDay.ToString();
            label5.Text = theMonth.ToString();
            label6.Text = theTime.ToString();
            label7.Text = theYear.ToString();
        }

        private void BirthdayButton_Click(object sender, EventArgs e)
        {

            String BirthDay = BirthdayText.Text;
            String BirthMonth = BirthMonthText.Text;
            String Birthyear = BirthYearText.Text;
            String BirthDate = BirthMonthText.Text + BirthdayText.Text;
            String Username = NameField.Text;
            DateTime theDate;
            theDate = DateTime.Now;

            int theDay = theDate.Day;
            int theMonth = theDate.Month;
            int theYear = theDate.Year;
            int theTime = theDate.Hour;
            label4.Text = theDay.ToString();
            label5.Text = theMonth.ToString();
            label6.Text = theTime.ToString();
            label7.Text = theYear.ToString();


            if (BirthdayText.Text == theDay.ToString() && BirthMonthText.Text == theMonth.ToString())
            {
                Singhappybirthday();
            }
            else if (theTime < 12)
            {
                MessageBox.Show("Good morning," + Username + "!", "Rise and Shine");
            }
            else if (theTime < 17)
            {
                MessageBox.Show("I am terribly sorry. I'm currently taking a siesta. Come back later!", "Mmmm");
            }
            if (theTime > 17)
            {
                MessageBox.Show("Lullaby and good night,\n"
                           + "With roses bedight,\n"
                           + "With lilies o'er spread\n"
                           + "Is baby's wee bed.\n"
                           + "Lay thee down now and rest,\n"
                           + "May thy slumber be blessed.\n"
        
                            + "Lullaby and good night,\n"
                            + "Thy mother's delight,\n"
                            + "Bright angels beside\n"
                            + "My darling abide.\n"
                            + "They will guard thee at rest,\n"
                            + "Thou shalt wake on my breast.\n" 
                            + "\n", "Brahm's Lullaby for " + Username);
            }
        }

        private void BinaryAge_Click(object sender, EventArgs e)
        {
            DateTime theDate;
            theDate = DateTime.Now;
            String Birthyear = BirthYearText.Text;
            int age = theDate.Year - Convert.ToInt32(BirthYearText.Text);
            BinaryLabel.Text = GetAsBinary(age);

        }

        private void Singhappybirthday()
        {
            DateTime theDate;
            theDate = DateTime.Now;
            String Birthyear = BirthYearText.Text;
            String Username = NameField.Text;
            int age = theDate.Year - Convert.ToInt32(BirthYearText.Text);
            if (age == 0)
            {
                int i = 0;
                while (i < age)
                {
                    MessageBox.Show("Happy birthday to you\n");
                    i++;

                }
            }


        }

        private static string GetAsBinary(int age)
        {
             if (age == 0)
          {
                return "O";
                    }

                    int PowerOf2 = 1;
                    while (PowerOf2 <= age)
                    {
                        PowerOf2 = PowerOf2*2;
                    }
                    PowerOf2 = PowerOf2/2;
                    string BinaryValue = "";
                    while (PowerOf2 > 0)
                    {
                        if (age >= PowerOf2)
                        {
                            age = age - PowerOf2;
                            BinaryValue = BinaryValue + "1";
                        }
                        else
                        {
                            BinaryValue = BinaryValue + "0";
                        }
                        PowerOf2 = PowerOf2/2;
                    }

                    return BinaryValue;

                }
            }
        }
    