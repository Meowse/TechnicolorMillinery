using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrushTeeth3
{
    static class Program
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String HowToBrush;
            HowToBrush = "1.  Acquire LiquidWasteReceptacle -- details TBD\n" +
                         "2.  Acquire a toothbrush	-- details TBD\n" +
                         "3.  CALL PROCEDURE \"Apply toothpaste to (the toothbrush we just acquired)\"\n" +
                         "4.  Put the cap back on the toothpaste\n" +
                         "5.  Put the toothpaste tube down\n" +
                         "6.  Open mouth\n" +
                         "7.  Place the toothpaste that is on the bristles against your teeth\n" +
                         "8.  Move the toothbrush back and forth in a circular manner on the teeth\n" +
                         "9.  Iterate motion over all the (exposed surfaces of the) teeth for two minutes\n" +
                         "10. Brush the tongue until you gag\n" +
                         "11. Remove toothbrush from your mouth\n" +
                         "12. Rinse the toothpaste out of your mouth and into the LiquidWasteReceptacle\n" +
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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
