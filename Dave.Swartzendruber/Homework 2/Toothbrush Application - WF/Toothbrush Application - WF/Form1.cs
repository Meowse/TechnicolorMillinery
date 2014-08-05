using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toothbrush_Application___WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void toothBrush(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Step 1:  Obtain Toothbrush\n"
                + "Step 2:  Obtain Toothpaste\n"
                + "Step 3:  Open Toothpaste\n"
                + "Step 4:  Squeeze enough Toothpaste to cover bristles\n"
                + "Step 5:  Place Toothbrush against teeth\n"
                + "Step 6:  Brush in an up and down motion to cover all exposed teeth\n"
                + "Step 7:  Rinse out mouth with water when finished brushing\n",
                "Tooth Brushing Instructions"
                
                
                );
        }

        private void sayHello(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Hello World ");
        }
    }
}
