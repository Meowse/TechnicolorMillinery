using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private const string VERBATIM_TOOTH_BRUSHING_INSTRUCTIONS =
@"Do you want white teeth?
Items required:

Toothpaste
Water
Liquid waste receptacle

How to get white sparkly odorless teeth:

Place yourself near a liquid waste receptacle
Pick up the toothpaste in your dominant hand
Unscrew the top of the toothpaste and put the top down
Make sure the bristles the toothbrush are pointed upward
Apply the toothpaste ontop the top part of the toothbrush
Only apply toothpaste to the length of the bristles
Put the toothpaste down and place the toothbrush in your dominant hand
Open your mouth and place your toothbrush on top of your teeth making sure the toothpaste on your teeth
Move your toothbrush back and forth along your teeth with little force horizontally for two minutes
Brush your tongue until you gag
Remove your toothbrush from your mouth and spit the liquid into the receptacle
Swish water in your mouth and spit again into liquid waste receptacle
Spitting is necessary to get rid of germs
Place the toothbrush down

NOW DO IT ALL OVER AGAIN BEFORE YOU SLEEP AND WAKE UP";
        public Form1()
        {
            InitializeComponent();
        }

        private void dosomethingclicked(object sender, EventArgs e)
        {
            MessageBox.Show(VERBATIM_TOOTH_BRUSHING_INSTRUCTIONS, "How to Brush Your Teeth!");
        }
    }
}
