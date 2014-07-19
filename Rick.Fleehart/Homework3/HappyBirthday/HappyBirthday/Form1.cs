using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyBirthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            SelectedDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        // if today is birthday, display Happy birthday song

        // if today is not birthday but morning display good morning
 
        // if today is not birthday but noon to 5pm display is taking a siesta

        // if today is not birthday but after 5PM then display lullaby



        //------------------ old code home -----------------------------
        private void label1_Click(object sender, EventArgs e)
        {
            //This should not be here but if I remove it everything explodes
        }
    }
}
