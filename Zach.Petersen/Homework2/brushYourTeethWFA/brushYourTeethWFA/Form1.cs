﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brushYourTeethWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static void taskTimer(int duration)
        {
            for (int a = duration; a >= 0; a--)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }

        int stepPosition = 1;

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Dictionary<int, string> dictionary =
            new Dictionary<int, string>();
            dictionary.Add(1, "Position yourself near the Liquid Waste Receptacle");
            dictionary.Add(2, "Pick up and hold the toothpaste in your right hand.");
            dictionary.Add(3, "Remove the cap from the toothpaste container.");
            dictionary.Add(4, "Pick up and hold the toothbrush in your left hand positioning it so that the bristles are oriented upwards.");
            dictionary.Add(5, "Align the toothpaste container, dispensing end first, with one end of the bristles on the toothbrush.");
            dictionary.Add(6, "Gently apply pressure to the toothpaste container while simultaneously moving the toothpaste container along the top of the bristles so as to apply a single layer of toothpaste to the brush. Upon reaching the opposite end of the bristles immediately stop applying pressure to the toothpaste container.");
            dictionary.Add(7, "Place the toothpaste container back onto its storage surface with its cap reattached.");
            dictionary.Add(8, "Keeping the toothbrush with the toothpaste covered bristles oriented in an upward fashion move the toothbrush to your right hand.");
            dictionary.Add(9, "Open your mouth and position the toothbrush against your front teeth so that the toothpaste covered bristles are in direct contact with the surface of your front teeth.");
            dictionary.Add(10, "To begin brushing move the toothbrush in a vertical up and down motion on your front teeth.");
            dictionary.Add(11, "To complete the brushing process move the toothbrush over all exposed surfaces of each tooth in your mouth.  Each tooth should receive approximately the same amount of brushing effort. Continue this process for a total of two minutes. At the end of two minutes position the toothbrush bristles onto your tongue and move the toothbrush over the whole surface of your tongue for ten seconds.");
            dictionary.Add(12, "When the brushing process is completed remove the toothbrush from your mouth and position it over the liquid waste receptacle for cleaning.");
            dictionary.Add(13, "To clean the toothbrush rinse with a sufficient amount of water to clean all toothpaste residue from the bristles and handle of the toothbrush. Once cleaning has been completed place the toothbrush back in its storage container.");
            dictionary.Add(14, "Next open your mouth and dispense three ounces of water into your mouth without swallowing any of the water. Close your mouth and swish the water back and forth for five seconds to clean the toothpaste from inside your mouth. After five seconds has elapsed position your mouth over the liquid waste receptacle and discharge the water from your mouth into the liquid waste receptacle.");

            if (stepPosition < 14)
            {
                insText.Text = dictionary[stepPosition];
                stepPosition++;
            } 
            
            else if (stepPosition == 14)
            {
                insText.Text = @"You have completed the process of brushing your teeth.";
                stepPosition = 1;
            }
	        
        }

    }
}
