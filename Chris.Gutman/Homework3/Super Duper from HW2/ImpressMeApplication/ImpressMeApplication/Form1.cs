using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBScript_RegExp_55;


namespace ImpressMeApplication
{

    public partial class Form1 : Form
    {
//        RegExp re;
//        MatchCollection rematches;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {

            string mystring;
            RegExp re = new RegExp();
            re.Multiline = false;
            re.Pattern = RegularExpressionBox.Text;
            re.Global = false;



            MatchCollection rematches = re.Execute(InputBox.Text);
            var output = rematches[0].Value;          

           
            if(rematches.Count != 0) 
            {
                ResultBox.Text = output;                

            }





        }

        public dynamic rematches { get; set; }

        private void Bye(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
