﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add1toInteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Convert label text to integer
            int Sum = Convert.ToInt32(label1.Text);
            // Increment integer by 1
            Sum++;
            // Delete warning message
            label2.Text = "";
            
            if (Sum > 10)
            {
                // Set sum back to zero
                Sum = 0;
                // Output warning message
                label2.Text = "I can't count beyond 10 so I've started you over.";
            }
            else
            {
                // Delete warning message
                label2.Text = "";
            }

            //Display the results in the label
            label1.Text = Convert.ToString(Sum);
        }
    }
}