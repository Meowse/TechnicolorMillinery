using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toothbrush_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            lblStatus.Text = "";
            List<string> instructions = new List<string> {
                "acquire a toothbrush, a toothpaste container containing toothpaste, a clean water source, and a receptacle for disposing of waste water",
                                 "pick up toothpaste container",
                                 "remove cap from toothpaste container",
                                 "pick up toothbrush by the handle",
                                 "with the toothbrush bristles pointing up, apply an amount of toothpaste less than or equal to the total size of the toothbrush bristle tips",
                                 "set down the toothpaste container",
                                 "optionally, slightly moisten the bristles and toothpaste",
                                 "insert bristle end of toothbrush into mouth",
                                 "press the bristle tips with toothpaste against front of teeth",
                                 "using small motions, rub the bristle tips against the exposed portion of each tooth: front, back and tops",
                                 "stop brushing once each tooth has been scrubbed",
                                 "remove toothbrush from mouth",
                                 "rinse off the bristle end of the toothbrush into the waste water receptacle using a small portion of your clean water source until bristles contain no more toothpaste",
                                 "set down the toothbrush",
                                 "spit used toothpaste from mouth into waste water receptacle",
                                 "insert a mouthful size amount of water from clean water source into mouth.  Do not swallow",
                                 "swish water around mouth to rinse used toothpaste from teeth",
                                 "spit water from mouth into waste water receptacle",
                                 "repeat previous three steps until either no more toothpaste remains in mouth or clean water source is depleted",
                                 "replace cap onto toothpaste container",
                                 "return toothbrush and toothpaste container to their respective storage area",
                                 "dispose of waste water receptacle if necessary"
            };
            int counter = 1;
            foreach(string step in instructions)
            {
                txtOutput.Text += string.Format("{0}. {1}{2}", counter.ToString(), step, Environment.NewLine);
                counter++;
            }

            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Completed!";
        }
    }
}
