using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private const string TOOTH_BRUSHING_INSTRUCTIONS =
        
            "Acquire LiquidWasteReceptacle -- details TBD\n" +
            "Acquire a toothbrush -- details TBD\n" +
            "Call Procedure \"Apply toothpaste to (the toothbrush acquired)\"n" +
            "Acquire toothpaste tube -- details TBD\n" +
            "Pick up your toothbrush\n" +
            "Pick up your toothpaste\n" +
            "Unscrew the top\n" +
            "Align the bristles with the opening of the tube\n" +
            "Make sure the bristles are pointing up\n" +
            "Make sure that the toothbrush is below the toothpaste\n" +
            "Gently squeeze a small amount of the toothpaste onto the toothbrush approximately 45 degree angle\n" +
            "\n"+
            "\n"+
             "\small\" -- the same size as the length and width of the bristles\""+
            "Pocedure \apply toothpaste to (the toothtube just acquired)\"\n" +
            "Put the cap back on the toothpaste\n" +
            "Put the toothpaste tube down\n" +
            "Open mouth\n" +
            "Place the toothpaste that is on the bristles against your teeth in a circular motion\n" +
            "Move the toothpaste back and forth horizontally on the teeth\n" +
            "Move on to chewing surfaces -- Hold the toothbrush flat and brush back and forth along these surfaces\n" +
            "Brush the inner surfaces of your teeth\n" +
            "Iterate motion over all the exposed surfaces of the teeth for two minutes\n" +
            "Brush the tongue until you gag\n" +
            "Remove toothbrush from your mouth\n" +
            "Rinse off toothbrush so there is no sign of toothpaste anywhere on the handle or bristles\n" +
            "Shake out the moisture on the bristles of the toothbrush and place it back in the holder\n" +
            "Rinse the toothpaste out of mouth (swish around your mouth) and spill it into the LiquidWasteReceptacle\n";

        public Form1()
        {
            InitializeComponent();
        }

        private void DoSomethingClicked(object sender, EventArgs e)
        {
            MessageBox.Show(TOOTH_BRUSHING_INSTRUCTIONS, "Show how to brush your TEETH");
        }

    }
}
