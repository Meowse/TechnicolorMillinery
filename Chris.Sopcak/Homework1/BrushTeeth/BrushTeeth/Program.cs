using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushTeeth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String HowToBrush;
            HowToBrush = "Acquire LiquidWasteReceptacle -- details TBD\n" +
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
                         "PROCEDURE \"Apply toothpaste to (the toothbrush we just acquired)\"\n" +
                         "	  Acquire toothpaste tube -- details TBD\n" +
                         "	  Pick up your toothbrush\n" +
                         "	  Pick up your toothpaste\n" +
                         "	  Unscrew the top\n" +
                         "	  Align the bristles with the opening of the tube\n" +
                         "	  Make sure the bristles are pointing up\n" +
                         "	  Make sure that the toothbrush is below the toothpaste\n" +
                         "	  Gently squeeze a small amount of the toothpaste onto the toothbrush\n" +
                         "	  \"small\" -- the same size as the length and width of the bristles";
            MessageBox.Show(HowToBrush, "How to Brush");
        }
    }
}