﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_Super_duper_extra_credit
{
    public partial class Form1 : Form
    {
        private int myInt = 1;

        public Form1()
        {
            InitializeComponent();
            labelInt.Text = myInt.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"How to brush your teeth:
                            Acquire LiquidWasteReceptacle -- details TBD
                            Acquire a toothbrush    -- details TBD
                            Apply toothpaste to (the toothbrush we just acquired)
                            Acquire toothpaste tube -- details TBD
                            Acquire a cup
                            Acquire a towel

                            Fill your cup with water
                            Pick up your toothbrush
                            Pick up your toothpaste
                            Unscrew the top
                            Align the bristles with the opening of the tube
                            Make sure the bristles are pointing up
                            Make sure that the toothbrush is below the toothpaste
                            Gently squeeze a small amount of the toothpaste onto the toothbrush
                                small -- the same size as the length and width of the bristles
                            Put the cap back on the toothpaste
                            Put the toothpaste tube down
                            Open mouth
                            Place the toothpaste that is on the bristles against your teeth
                            Move the toothbrush back and forth horizontally on the teeth
                            Iterate motion over all the (exposed surfaces of the) teeth for two minutes
                            Brush the tongue until you gag
                            Remove toothbrush from your mouth
                            Hold up your cup
                            Put water in your mouth but do not swallow, swish around in your mouth instead
                            Spit water out into the into the LiquidWasteReceptacle
                            Repeat the above rinsing steps until toothpaste is cleaned from your mouth
                            Rinse your toothbrush under flowing water until clean
                            Wipe your mouth with towel
                            ",
                            @"Teeth brushing steps");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            if (radioButton1.Checked)
            {
                listBox.Items.Add("Combo1");
            }
            else if(radioButton2.Checked)
            {
                listBox.Items.Add("Combo2");
            }

            if(checkBox.Checked)
            {
                listBox.Items.Add("Extra Cheese");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if (name == @"Mickey")
            {
                labelNameResult.Text = "Hello, teacher!";
            }
            else
            {
                labelNameResult.Text = "Hello, " + textBoxName.Text;
            }
        }

        private void buttonIntIncrease_Click(object sender, EventArgs e)
        {
            myInt++;
            if (myInt > 10)
            {
                MessageBox.Show("Number too big!", "Warning");
                myInt = 0;
            }
            labelInt.Text = myInt.ToString();
        }
    }
}
