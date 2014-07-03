using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
       
        private const string VERBATIM_TOOTH_BRUSHING_INSTRUCTIONS =
@"Acquire: ToothPasteTube -- details TBD
Acquire: ToothBrush -- details TBD
Acquire: LiquidVessel -- details TBD
Acquire: LiquidWasteRecepticle -- details TBD
    Pick up ToothPasteTube with right hand
CALL PROCEDURE ""RemoveTubeCap""
CALL PROCEDURE ""ApplyToothPaste(ToothBrush)""
CALL PROCEDURE ""ReplaceTubeCap""
    Put the ToothPasteTube down on the LiquidWasteRecepticle
    Transfer ToothBrush to right hand
    Fill LiquidVessel from faucet on LiquidWasteRecepticle
    Wet ToothBrush bristles with water from faucet on LiquidWasteRecepticle
    Open mouth wide
    Put bristle end of ToothBrush in mouth
CALL PROCEDURE ""Brush (lower right)""
CALL PROCEDURE ""Brush (lower left)""
CALL PROCEDURE ""Brush (upper right)""
CALL PROCEDURE ""Brush (upper left)""
    Close mouth
CALL PROCEDURE ""Brush (upper fronts)""
CALL PROCEDURE ""Brush (lower fronts)""
    Remove toothbrush from Mouth
CALL PROCEDURE ""Rinse (Mouth)""
CALL PROCEDURE ""Rinse (ToothBrush)""
    Return
PROCEDURE ""ApplyToothPaste(ToothBrush)""
	Align the ToothBrush bristles with the opening of ToothPasteTube
        Make sure the bristles are pointing up
        Make sure that ToothBrush is below the ToothPasteTube
        Gently squeeze a small amount of the ToothPaste onto the ToothBrush
            ""small"" -- the same size as the length and width of the ToothBrush bristles
PROCEUDRE ""Brush(AreaOfMouth)""
    position ToothBrush bristles over teeth in (AreaOfMouth)
    apply gentle constant pressure between toothbrush and teeth
    Repeat for 30 seconds: move toothbrush back and forth
    CALL PROCEDURE: Rinse(Mouth)
    Return
PROCEDURE ""RemoveTubeCap""
	if threaded cap then while cap does not come off, turn cap counter-clockwise until cap comes free
        put cap down on sink
	if flip-top cap then flip cap open
    Return
PROCEDURE ""ReplaceTubeCap""
    if threaded cap then pick up cap from sink
        align cap with threads
        while cap is turning, turn cap clockwise
    if flip-top cap then flip cap closed
    Return
PROCEDURE ""Rinse(thing)""
if Thing is Mouth then
	pick up glass from sink countertop
	Repeat 3 times:
		move glass to lips
		tilt glass up so that water flows from glass to mouth
		remove glass from lips
		close mouth
		swish water around mouth for 30 seconds
	spit water into sink
if thing is ToothBrush then
	Rinse ToothBrush under running water for 20 seconds
Return
";

        public Form1()
        {
            InitializeComponent();
        }

        private void DoSomethingClicked(object sender, EventArgs e)
        {
            MessageBox.Show(VERBATIM_TOOTH_BRUSHING_INSTRUCTIONS, "How to Brush Your Teeth");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
