using System;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        static void Main1()
        {
            MessageBox.Show("Will this work?");
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form1 = new CalculatorForm();
            form1.Text = "This banana is unsatisfying";
            form1.Show();

            form1 = new CalculatorForm();
            form1.Text = "This banana also fails to please";
            form1.Show();

            var magicBanana = new CalculatorForm();
            magicBanana.Text = "I FOUND IT!!!!";

            // Application.Run(magicBanana);

            magicBanana.Closed += KillApplicationNow;
            magicBanana.Show();
            Application.Run();
        }

        private static void KillApplicationNow(object sender, EventArgs e)
        {
            Application.Exit();
//            Application.Restart();
        }
    }
}
