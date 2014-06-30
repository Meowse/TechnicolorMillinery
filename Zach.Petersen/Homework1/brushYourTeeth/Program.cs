using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brushYourTeeth
{
    class Program
    {
        static void Main(string[] args)
        {
            //store items required
            const string brushingReqs = "Liquid Waste Receptacle\nWater\nTooth Brush\nTooth Paste";
            
            //introduction
            Console.WriteLine("Welcome to How to Brush Your Teeth!\n");
            Console.WriteLine("The following items are required:\n");
            Console.Write(brushingReqs);
            Console.WriteLine("\nOnce you have located these items press any key to continue.");
            Console.Read();
           
            //tooth brushing process
            BrushTeeth();
            Console.Read();

        }

        //9 out of 10 dentists agree that this is the start of the brushing process
        static void BrushTeeth()
        {
            var brushingSteps = new string[,] { //create and initialize array of instructions
                //stepId,requiresTimer,duration,instruction
                //{"","0","0",""},
                {"1","0","0","Position yourself near the Liquid Waste Receptacle"},
                {"2","0","0","Pick up and hold the toothpaste in your right hand"},
                {"3","0","0","Remove the cap from the toothpaste container"},
                {"4","0","0","Pick up and hold the toothbrush in your left hand positioning it so that the bristles are oriented upwards"},
                {"5","0","0","Align the toothpaste container, dispensing end first, with one end of the bristles on the toothbrush"},
                {"6","0","0","Gently apply pressure to the toothpaste container while simultaneously moving the toothpaste container along the top of the bristles so as to apply a single layer of toothpaste to the brush. Upon reaching the opposite end of the bristles immediately stop applying pressure to the toothpaste container"},
                {"7","0","0","Place the toothpaste container back onto its storage surface with its cap reattached"},
                {"8","0","0","Keeping the toothbrush with the toothpaste covered bristles oriented in an upward fashion move the toothbrush to your right hand"},
                {"9","0","0","Open your mouth and position the toothbrush against your front teeth so that the toothpaste covered bristles are in direct contact with the surface of your front teeth"},
                {"10","0","0","To begin brushing move the toothbrush in a vertical up and down motion on your front teeth"},
                {"11","1","300","To complete the brushing process move the toothbrush over all exposed surfaces of each tooth in your mouth.  Each tooth should receive approximately the same amount of brushing effort. Continue this process for a total of two minutes. At the end of two minutes position the toothbrush bristles onto your tongue and move the toothbrush over the whole surface of your tongue for ten seconds"},
                {"12","0","0","When the brushing process is completed remove the toothbrush from your mouth and position it over the liquid waste receptacle for cleaning"},
                {"13","0","0","To clean the toothbrush rinse with a sufficient amount of water to clean all toothpaste residue from the bristles and handle of the toothbrush. Once cleaning has been completed place the toothbrush back in its storage container"},
                {"14","1","5","Next open your mouth and dispense three ounces of water into your mouth without swallowing any of the water. Close your mouth and swish the water back and forth for five seconds to clean the toothpaste from inside your mouth. After five seconds has elapsed position your mouth over the liquid waste receptacle and discharge the water from your mouth into the liquid waste receptacle."},
	        };


        }
    }
}
