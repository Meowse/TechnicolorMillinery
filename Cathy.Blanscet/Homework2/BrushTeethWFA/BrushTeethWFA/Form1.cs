﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrushTeethWFA
{
    public partial class Form1 : Form
    {
        private const string BrushingInstructions = "Acquire LiquidWasteReceptacle -- details TBD\n" +
            "Acquire a toothbrush	-- details TBD\n" +
            "CALL PROCEDURE \"Apply toothpaste to (the toothbrush we just acquired)\"\n" +
            "Put the cap back on the toothpaste\n" +
            "Put the toothpaste tube down\n" +
            "Open mouth\n" +
            "Place the toothpaste that is on the bristles against your teeth\n" +
            "Move the toothbrush back and forth horizontally on the teeth\n" +
            "Iterate motion over all the (exposed surfaces of the) teeth for two minutes\n" +
            "Brush the tongue until you gag\n" +
            "Remove toothbrush from your mouth\n" +
            "Rinse the toothpaste out of your mouth and into the LiquidWasteReceptacle\n" +
            "\n" +
            "\n" +
            "PROCEDURE \"Apply toothpaste to (the toothbrush we just acquired)\"\n" +
            "	Acquire toothpaste tube -- details TBD\n" +
            "	Pick up your toothbrush in one hand\n" +
            "	Pick up your toothpaste in the other hand\n" +
            "	Unscrew the top\n" +
            "	Align the bristles with the opening of the tube\n" +
            "	Make sure the bristles are pointing up\n" +
            "	Make sure that the toothbrush is below the toothpaste\n" +
            "	Gently squeeze a small amount of the toothpaste onto the toothbrush\n" +
            "		\"small\" -- the same size as the length and width of the bristles or the size of a small pea.\"";

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMeButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show(BrushingInstructions, "Insructions on how to brush your teeth");
        }

        private void CloseMeButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SayHelloButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
