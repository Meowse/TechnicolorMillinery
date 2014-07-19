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

        String TodayDateTime = DateTime.Now.ToString("M/d/yyyy");

    

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Puts the selected date into the label: SelectedDate
            SelectedDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        // if today is birthday, display Happy birthday song into label OutputLabel

        // if today is not birthday but morning display good morning into label OutputLabel

        // if today is not birthday but noon to 5pm display is taking a siesta into label OutputLabel

        // if today is not birthday but after 5PM then display lullaby into label OutputLabel



        //------------------ old code home -----------------------------
        private void label1_Click(object sender, EventArgs e)
        {
            //This should not be here but if I remove it everything explodes
        }
    }
}
