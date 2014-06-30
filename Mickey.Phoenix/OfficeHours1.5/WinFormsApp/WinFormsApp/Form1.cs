using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private const string TOOTH_BRUSHING_INSTRUCTIONS =
            "Acquire LiquidWasteReceptacle -- details TBD\n" +
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
            "	Pick up your toothbrush\n" +
            "	Pick up your toothpaste\n" +
            "	Unscrew the top\n" +
            "	Align the bristles with the opening of the tube\n" +
            "	Make sure the bristles are pointing up\n" +
            "	Make sure that the toothbrush is below the toothpaste\n" +
            "	Gently squeeze a small amount of the toothpaste onto the toothbrush\n" +
            "		\"small\" -- the same size as the length and width of the bristles\"";

        private const string VERBATIM_TOOTH_BRUSHING_INSTRUCTIONS =
@"Acquire LiquidWasteReceptacle -- details TBD
Acquire a toothbrush	-- details TBD
CALL PROCEDURE ""Apply toothpaste to (the toothbrush we just acquired)""
Put the cap back on the toothpaste
Put the toothpaste tube down
Open mouth
Place the toothpaste that is on the bristles against your teeth
Move the toothbrush back and forth horizontally on the teeth
Iterate motion over all the (exposed surfaces of the) teeth for two minutes
Brush the tongue until you gag
Remove toothbrush from your mouth
Rinse the toothpaste out of your mouth and into the LiquidWasteReceptacle


PROCEDURE ""Apply toothpaste to (the toothbrush we just acquired)""
	Acquire toothpaste tube -- details TBD
	Pick up your toothbrush
	Pick up your toothpaste
	Unscrew the top
	Align the bristles with the opening of the tube
	Make sure the bristles are pointing up
	Make sure that the toothbrush is below the toothpaste
	Gently squeeze a small amount of the toothpaste onto the toothbrush
		""small"" -- the same size as the length and width of the bristles";

        public Form1()
        {
            InitializeComponent();
        }

        private void DoSomethingClicked(object sender, EventArgs e)
        {
            MessageBox.Show(VERBATIM_TOOTH_BRUSHING_INSTRUCTIONS, "How to Brush Your Teeth");
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            Application.Exit();
            char myChar = 'a';
            string myString = "this is my string";
            char myOtherChar = 'h';
        }
    }
}
