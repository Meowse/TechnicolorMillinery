using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrushTeethWF
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* when clicked shows the text */
            String theText;
            theText = "Acquire LiquidWasteReceptacle -- details TBD\n";
            theText += " Acquire a toothbrush	-- details TBD\n";
            theText += "Acquire a cup of water -- details TBD\n";
            theText += "CALL PROCEDURE 'Apply toothpaste to (the toothbrush we just acquired)'\n";
            theText += "Open mouth\n";
            theText += "Place the toothpaste that is on the bristles against your teeth\n";
            theText += "Move the toothbrush back and forth horizontally on the teeth\n";
            theText += "Iterate motion over all the (exposed surfaces of the) teeth for two minutes, total\n";
            theText += "Brush the tongue for 30 seconds ( until you gag )\n";
            theText += "Remove toothbrush from your mouth\n";
            theText += "Put down the toothbrush.\n";
            theText += "Rinse the toothpaste out of your mouth USING a 'cup of water' and into the LiquidWasteReceptacle\n";
            theText += "Close mouth\n\n";
            theText += "CALL PROCEDURE 'Put away Toothpaste and Toothbrush (Toothpaste tube we are using, Toothbrush we are using'\n";

            MessageBox.Show(theText, "How to Brush your Teeth");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
