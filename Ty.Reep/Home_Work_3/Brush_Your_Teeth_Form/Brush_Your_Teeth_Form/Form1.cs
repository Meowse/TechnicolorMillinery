using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brush_Your_Teeth_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Step1(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Tell Teenage to go apply War Paint Some Where Else\n" +
                "Receive Dirty Look from Teenager\n" +
                "Acquire LiquidWasteReceptacle",
                "Acquire Bathroom");
        }

        private void Step2(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Acquire a toothbrush\n" +
                "Acquire toothpaste tube\n" +
                "Pick up your toothbrush\n" +
                "Pick up your toothpaste\n" +
                "Unscrew the top with one hand\n" +
                "Make sure the bristles are pointing up\n" +
                "Make sure that the toothbrush is below the toothpaste\n" +
                "Align the bristles with the opening of the tube\n" +
                "Gently squeeze a small amount of the toothpaste onto the toothbrush\n" +
                "small = the same size as the length and width of the bristles\n" +
                "Put the cap back on the toothpaste\n" +
                "Put the toothpaste tube down",
                "Perpetration");

        }

        private void Step3(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Open mouth and Place the toothpaste that is on the bristles against your teeth\n" +
                "Move the toothbrush back and forth horizontally on the teeth\n" +
                "Iterate motion over all the (exposed surfaces of the) teeth for two minutes\n" +
                "Brush the tongue until you gag\n" +
                "Remove toothbrush from your mouth\n" +
                "Rinse the toothpaste out of your mouth and into the LiquidWasteReceptacle",
                "The Task");
        }
    }
}
