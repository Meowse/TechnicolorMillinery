﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappybirthdayStarter
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //standards
        int Noon = 12;
        int Evening = 17;

        private string goodMorningSong = "Good morning, good mooorning!\n" +
                                         "We've talked the whole night through, \n" +
                                         "Good morning, good mooorning, \n" +
                                         "to you!";

        private string siestaSong = "Dave's not here, man";

        private string lullabySong = "You will go to sleep or I will PUT you to sleep!";

        
        

        //practices
        private void Submitbutton_Click(object sender, EventArgs e)
        {

            string name = namefield.Text;

            // I don't understand yet why I cannot simply put both the birthdaysong string and/or the current date and
            //time items up in standards.
            //They will have to remain in here until I figure out a better way. I have a feeling the "better way" is 
            //to feature all the info in "standards" in a library that's referenced

            string birthdaySongwords = "What day is today? \n" +
                                  "It's " + name + "'s birthday!\n" +
            "What a day for a birthday!\n" +
            "Let's all have some cake.";
 
            

            string checkdate = enteredDate.Text;
            
         
            var birthDateString = checkdate.Split(new[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);
            String birthMonth   = birthDateString[0];
            String birthDay     = birthDateString[1];
            String birthYear    = birthDateString[2];

            DateTime currentDateTime = DateTime.Now;
            string currentMonth = currentDateTime.Month.ToString();
            string currentDay = currentDateTime.Day.ToString();
            string currentYear = currentDateTime.Year.ToString();
            string currentHour = currentDateTime.Hour.ToString();
            string currentMinute = currentDateTime.Minute.ToString();


            if (Convert.ToInt32(currentYear) >= Convert.ToInt32(birthYear))
            {
                int age = (Convert.ToInt32(currentYear) - (Convert.ToInt32(birthYear)));



                agelabel.Text = "You are " + age + " years old";
                binarylabel.Text = "Your age in Binary is: " + ToBinary(age);

                if (currentMonth == birthMonth && currentDay == birthDay)
                {
                   // while (age > 0)
                    //{
                        birthdaySong(age, birthdaySongwords);
                        
                       // age -= 1;
                    //}

                }
                else
                {
                    if (Convert.ToInt32(currentHour) < Noon)
                    {
                        MessageBox.Show(goodMorningSong);
                    }
                    if (Convert.ToInt32(currentHour) >= Noon && Convert.ToInt32(currentHour) < Evening)
                    {
                        MessageBox.Show(siestaSong);
                    }
                    if (Convert.ToInt32(currentHour) >= Evening)
                    {
                        MessageBox.Show(lullabySong);
                    }
                }
            }
            else
            {
                agelabel.Text = "You're from the future? Impressive.";
                binarylabel.Text = "Do they have negative binaries in the future?";
                MessageBox.Show("Please enter your actual birthdate, or make this program better with your future spaceman magic.");              
            } 

        }

        public static string birthdaySong(int age, string birthdaySongwords)
        {
            while (age > 0)
            {
                birthdaySongwords += birthdaySongwords + "\n";
                age -= 1;
            }
            MessageBox.Show(birthdaySongwords);
            return (birthdaySongwords);
        }

        public static string ToBinary(Int64 Decimal)//blatantly stolen from office hours.
        {
            // Declare a few variables we're going to need
            Int64 BinaryHolder;
            char[] BinaryArray;
            string BinaryResult = "";

            while (Decimal > 0)
            {
                BinaryHolder = Decimal % 2;
                BinaryResult += BinaryHolder;
                Decimal = Decimal / 2;
            }

            // The algoritm gives us the binary number in reverse order (mirrored)
            // We store it in an array so that we can reverse it back to normal
            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);

            return BinaryResult;
        }
        }       
    }

