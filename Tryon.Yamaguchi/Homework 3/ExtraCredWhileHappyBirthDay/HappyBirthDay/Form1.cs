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
            int dateDiff = ((DateTime.Now.Month - birthDate.Month)-(DateTime.Now.Day - birthDate.Day));

            string bDayLines = "Happy Birthday to You!\n";
            
            if (dateDiff == 0 )
            {
                int i = 0;
                while (i < Age)
                {
                    bDayLines+= "Happy Birthday to You!\n";
                    i++;
                }
                lblHBDSong.Text = bDayLines +
                                  "Happy Birthday Dear " + txtName.Text + "!\n" +
                                  "Happy Birthday to You!\n";
            }
            else if (System.DateTime.Now.Hour < 12)
            {
                lblHBDSong.Text = "Good morning, good morning\n" +
                                  "We've danced the whole night through\n" +
                                  "Good morning, good morning to you\n" +

                                  "Good morning, good morning\n" +
                                  "It's great to stay up late\n" +
                                  "Good morning, good morning to you\n" +

                                  "When the band began to play\n" +
                                  "The sun was shining bright\n" +
                                  "Now the milkman's on his way\n" +
                                  "It's too late to say goodnight...\n";
            }
            else if (System.DateTime.Now.Hour > 17)
            {
                lblHBDSong.Text = "Lullaby and good night,\n" +
                                  "With roses bedight,\n" +
                                  "With lilies o'er spread\n" +
                                  "Is baby's wee bed.\n" +
                                  "Lay thee down now and rest,\n" +
                                  "May thy slumber be blessed...\n";
            }
            else
            {
                lblHBDSong.Text = "Sorry, We are out for a Siesta!";
            }

        }
    }
}
