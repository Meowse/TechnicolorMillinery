using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Check for Teeth
	If HaveTeeth then proceed
	Else Acquire Dentures & Exit
Acquire LiquidWasteReceptacle -- details TBD
Acquire LiquidDrinkingReceptacle
Acquire a Toothbrush (interface brush) -- details TBD
Prepare Toothbrush
	Empty hands of all objects
	Acquire Toothpaste tube -- details TBD
	Pick up your toothpaste
	Unscrew the top
	Place top on flat surface
	If right hand IsOccupied
		Pick up your toothbrush with left hand
	Else
		Pick up your toothbrush with right hand
	Align the bristles with the opening of the tube
	Make sure the bristles are pointing up
	Make sure that the toothbrush is below the toothpaste
	Gently squeeze a small amount of the toothpaste onto the toothbrush
	Put the cap back on the toothpaste
	Put the toothpaste tube down
Open mouth
Place PreparedToothbrush bristles on teeth using light pressure
Move the PreparedToothbrush back and forth horizontally on the teeth
Iterate motion over all the (exposed surfaces of the) teeth for two minutes
Brush the tongue until you gag
Remove PreparedToothbrush from your mouth
Close mouth
Spit contents of mouth into LiquidWasteReceptacle
Prepare Rinse
	Turn on WaterDispenser
	Pick up LiquidDrinkingReceptacle, open side facing up
	Place LiquidDrinkingReceptacle underneath water for 2 seconds
Begin Rinse
	Rinse PreparedToothbrush using WaterDispenser
	Turn off WaterDispenser
	Put toothbrush away
	Pick up Filled LiquidDrinkingReceptacle
	Open Mouth
	Tilt Head back
	Pour ~2oz of RinseWater into open mouth
	Close Mouth
	Push RinseWater around mouth
	Spit RinseWater into LiquidWasteReceptacle
End Rinse");
        }
    }
}
