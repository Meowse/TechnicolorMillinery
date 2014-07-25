using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyBirthDay
{
    public partial class frmHappyBirthday : Form
    {
        public frmHappyBirthday()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime todayDate = DateTime.Today;
            DateTime birthDate = dtpCalendar.Value.Date;

            int bMonth = birthDate.Month;
            int dMonth = birthDate.Day;
            int Age = DateTime.Now.Year - birthDate.Year;
            int dateDiff = ((DateTime.Now.Month - birthDate.Month) - (DateTime.Now.Day - birthDate.Day));

            
            if (dateDiff == 0)
            {
                lblBinary.Text = "You binary age is " + GetAsBinary(Age) + " .\n";

                lblHBDSong.Text = GetHBDSong(Age, txtName.Text);

            }
            else if (System.DateTime.Now.Hour < 12)
            {
                lblHBDSong.Text = GetGMSong();
            }
            else if (System.DateTime.Now.Hour > 17)
            {
                lblHBDSong.Text = GetLullbaySong();
            }
            else
            {
                lblHBDSong.Text = "Sorry, We are out for a Siesta!";
            }

        }

        private static string GetAsBinary(int decimalValue)
        {
            string binaryValue = "";
            int powerOf2 = 1;

            if (decimalValue == 0)
            {
                return "0";
            }

                while (powerOf2 <= decimalValue)
                {
                    powerOf2 = powerOf2*2;

                }
                powerOf2 = powerOf2/2;

                while (powerOf2 < 0)
                {
                    if (decimalValue >= powerOf2)
                    {
                        decimalValue = decimalValue - powerOf2;
                        binaryValue = binaryValue + "1";
                    }
                    else
                    {
                        binaryValue = binaryValue + "0";
                    }
                    powerOf2 = powerOf2/2;
                }
 
            return binaryValue;
        }

        private static string GetHBDSong(int bYear, string bName)
        {

            string bDayLines = "Happy Birthday to You!\n";

            int i = 0;
            while (i < bYear)
            {
                bDayLines += "Happy Birthday to You!\n";
                i++;
            }

            bDayLines += bDayLines + "Happy Birthday Dear " + bName + "!\n" +
                                     "Happy Birthday to You!\n";
            return bDayLines;
        }

        private static string GetGMSong()
        {
            string gMorningLines = "Good morning, good morning\n" +
                                   "We've danced the whole night through\n" +
                                   "Good morning, good morning to you\n" +
                                   "Good morning, good morning\n" +
                                   "It's great to stay up late\n" +
                                   "Good morning, good morning to you\n" +

                                   "When the band began to play\n" +
                                   "The sun was shining bright\n" +
                                   "Now the milkman's on his way\n" +
                                   "It's too late to say goodnight...\n";
            return gMorningLines;
        }

        private static string GetLullbaySong()
        {
            string lullabySong = "Lullaby and good night,\n" +
                                 "With roses bedight,\n" +
                                 "With lilies o'er spread\n" +
                                 "Is baby's wee bed.\n" +
                                 "Lay thee down now and rest,\n" +
                                 "May thy slumber be blessed...\n";
            return lullabySong;
        }
    }
}
