﻿using System;
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

        // tell them how old they are in years.

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

            //Create todays Date and all of its individual parts
            DateTime TodayDateTime = DateTime.Now;
            String TodaysYear = TodayDateTime.Year.ToString();
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

            // you asked for it: Vogon poetry in the evening
            String SeistaSong = "Oh freddled gruntbuggly, Thy micturitions are to me, \n" ;
            SeistaSong += "As plurdled gabbleblotchits, On alurgid bee,\n";
            SeistaSong += "...blah blah blah, Vogon poetry annoys me";

            String EveningSong = "It getting dark " + EnteredName + "\n";
            EveningSong += "You better get inside before the zombies get you!\n";
            EveningSong += "and if you are still alive have a nice sleep\n";


            if (thebirthMonth == TodaysMonth && thebirthDay == TodaysDay)
            {
                // if today is birthday (month & day are today, display Happy birthday song message box
                MessageBox.Show(BirthdaySong + HowManyYearsOld(thebirthYear, TodaysYear));
                //Then do binary
                MessageBox.Show(BirthdaySong + HowManyYearsOldBinary(thebirthYear, TodaysYear));
            }
            else
            {
                if (Convert.ToInt32(TodaysHour) < Noon)
                {
                    // if today is not birthday but morning display good morning into  message box
                    MessageBox.Show(MorningSong + HowManyYearsOld(thebirthYear, TodaysYear));
                }

                if (Convert.ToInt32(TodaysHour) < Evening)
                {
                    // if today is not birthday but noon to 5pm display is taking a siesta into message box
                    MessageBox.Show(SeistaSong + HowManyYearsOld(thebirthYear, TodaysYear));
                }
                if (Convert.ToInt32(TodaysHour) > Evening)
                {
                    // if today is not birthday but after 5PM then display lullaby into message box
                    MessageBox.Show(EveningSong + HowManyYearsOld(thebirthYear, TodaysYear));
                }
            }
       }


        public String HowManyYearsOld(String BirthYear, String TodaysYear) {
            // subtract todyas year from the entered year to find out how old they are
            int YearsOld = Convert.ToInt32(TodaysYear) - Convert.ToInt32(BirthYear);

            return "\nYou are " + YearsOld.ToString() + " years old today!";
    
        }

        public String HowManyYearsOldBinary(String BirthYear, String TodaysYear)
        {
            //1   1  1  1  1 1 1 1  binary digits
            //128 64 32 16 8 4 2 1  what each means
            String OnesBit = "1";   //This is to build the BinaryNumber
            String ZerosBit = "0";  //This is to build the BinaryNumber
            String BinaryNumber = ""; //initialize to nothing

            int remainder = 0;

            int YearsOld = Convert.ToInt32(TodaysYear) - Convert.ToInt32(BirthYear); // how many years old

            int PowerOf2 = 128; //start at the top

            // now convert from decimal to binary
            // first pass check how many 128 are there?
            if (YearsOld / PowerOf2 > 0)
            {
                // add a 1 to the BinaryNumber
                BinaryNumber =  OnesBit;
                remainder = YearsOld - PowerOf2; // whats left for the next operation
            }
            else
            {
                // add a 0 to the BinaryNumber
                BinaryNumber = ZerosBit;
                remainder = YearsOld;
            }


            //----------- loop this later ---------------------
            //Second pass 64 ----------------------------
            PowerOf2 = PowerOf2 / 2;

            if (remainder / PowerOf2 > 0)
            {
                // add a 1 to the BinaryNumber
                BinaryNumber = BinaryNumber + OnesBit;
                remainder = remainder - PowerOf2; // whats left for the next operation
            }
            else
            {
                // add a 0 to the BinaryNumber
                BinaryNumber = BinaryNumber + ZerosBit;
                //remainder = remainder; // whats left for the next operation
            }

            //Third pass 32 ----------------------------
            PowerOf2 = PowerOf2 / 2;

            if (remainder / PowerOf2 > 0)
            {
                // add a 1 to the BinaryNumber
                BinaryNumber = BinaryNumber + OnesBit;
                remainder = remainder - PowerOf2; // whats left for the next operation
            }
            else
            {
                // add a 0 to the BinaryNumber
                BinaryNumber = BinaryNumber + ZerosBit;
                //remainder = remainder; // whats left for the next operation
            }

           
            //Fourth pass 16 -------------------------------
            PowerOf2 = PowerOf2 / 2;
            if (remainder / PowerOf2 > 0)
            {
                // add a 1 to the BinaryNumber
                BinaryNumber = BinaryNumber + OnesBit;
                remainder = remainder - PowerOf2; // whats left for the next operation
            }
            else
            {
                // add a 0 to the BinaryNumber
                BinaryNumber = BinaryNumber + ZerosBit;
                //remainder = remainder; // whats left for the next operation
            }

            //Fifth pass 8 -------------------------
            PowerOf2 = PowerOf2 / 2;
            if (remainder / PowerOf2 > 0)
            {
                // add a 1 to the BinaryNumber
                BinaryNumber = BinaryNumber + OnesBit;
                remainder = remainder - PowerOf2; // whats left for the next operation
            }
            else
            {
                // add a 0 to the BinaryNumber
                BinaryNumber = BinaryNumber + ZerosBit;
                //remainder = remainder; // whats left for the next operation
            }

            //Sixth pass 4 -------------------
            PowerOf2 = PowerOf2 / 2;
            if (remainder / PowerOf2 > 0)
            {
                // add a 1 to the BinaryNumber
                BinaryNumber = BinaryNumber + OnesBit;
                remainder = remainder - PowerOf2; // whats left for the next operation
            }
            else
            {
                // add a 0 to the BinaryNumber
                BinaryNumber = BinaryNumber + ZerosBit;
                //remainder = remainder; // whats left for the next operation
            }

            //Seveth pass 2 ---------------------
            PowerOf2 = PowerOf2 / 2;
            if (remainder / PowerOf2 > 0)
            {
                // add a 1 to the BinaryNumber
                BinaryNumber = BinaryNumber + OnesBit;
                remainder = remainder - PowerOf2; // whats left for the next operation
            }
            else
            {
                // add a 0 to the BinaryNumber
                BinaryNumber = BinaryNumber + ZerosBit;
                //remainder = remainder; // whats left for the next operation
            }

            //Eigth pass 1 --------------------------
            PowerOf2 = PowerOf2 / 2;
            if (remainder / PowerOf2 > 0)
            {
                // add a 1 to the BinaryNumber
                BinaryNumber = BinaryNumber + OnesBit;
                remainder = remainder - PowerOf2; // whats left for the next operation
            }
            else
            {
                // add a 0 to the BinaryNumber
                BinaryNumber = BinaryNumber + ZerosBit;
                //remainder = remainder; // whats left for the next operation
            }

            //----------- loop this later ---------------------


            return "\nYou are " + BinaryNumber + " years old today (in binary)!"; 
        }
        
        //------------------ old code home -----------------------------
        private void label1_Click(object sender, EventArgs e)
        {
            //This should not be here but if I remove it everything explodes
        }
    }
}
