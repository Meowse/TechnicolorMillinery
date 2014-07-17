using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2_Part_2
{
    public partial class BrushInstructions : Form
    {
        public BrushInstructions()
        {
            InitializeComponent();
        }

        private void BrushTeeth(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions\n"
    +"\n"
    + "1. Acquire Materials, including:\n"
	+ "     -LiquidWasteReceptacle -- details TBD\n"
	+ "     -Toothbrush	-- details TBD\n"
	+ "     -Toothpaste tube -- details TBD\n"
    + "\n"
+ "2. Properly set up materials for brushing:\n"
	+ "     -Pick up your toothpaste tube with your hands\n"
	+ "     -Unscrew the top\n"
    + "     -Place cap on flat surface nearby, preferably LiquidWasteReceptacle\n"
	+ "     -Hold toothpaste tube with your preferred hand\n"
	+ "     -Pick up toothbrush with free hand\n"
	+ "     -Align the toothbrush bristles with the opening of the tube\n"
	+ "     -Make sure the bristles are pointing up\n"
	+ "     -Make sure that the toothbrush is below the toothpaste\n"
	+ "     -Gently squeeze an amount (roughly equal to fingertip size) of toothpaste onto\n"
    + "         the toothbrush\n"
	+ "     -Put the toothpaste tube down\n"
    + "\n"
+ "3. The Brushing\n"
    + "     -Open mouth\n"
	+ "     -Carefully draw the toothbrush into your mouth\n"
	+ "     -Place the toothpaste that is on the bristles against your teeth\n"
	+ "     -Move the toothbrush in a gentle circular motion across the teeth\n"
	+ "     -Iterate motion over all the (exposed surfaces of the) teeth for two minutes\n"
	+ "     -Brush the tongue for your preferred amount of time, not to exceed 10 seconds\n" 
	+ "     -Remove toothbrush from your mouth\n"
    + "\n"
+ "4.  Cleaning up\n"
    +"      -Rinse the toothpaste out of your mouth and into the LiquidWasteReceptacle\n"        
    +"      -Run the bristles of the toothbrush under water from faucet in\n"
    +"          LiquidWastereceptacle to clean toothbrush\n"
    +"      -Tighten cap back on toothpaste tube\n"     
    +"      -Pack materials (toothpaste tube and toothbrush) back to proper destination\n", 
               "Hello World!");
        }

        private void ExpertStatus(object sender, EventArgs e)
        {
            MessageBox.Show("Hope the tutorial was informative. Happy brushing!" , "Congratulations");
        }
    }
}
