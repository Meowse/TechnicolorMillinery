using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrushTeeth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Teeth Brushing App 1.0");
            Console.WriteLine("Press a key to begin");
            Console.ReadKey();

            Console.WriteLine("\n\nAcquire LiquidWasteReceptacle -- details TBD");
            Console.WriteLine("Acquire a toothbrush	-- details TBD");
            Console.WriteLine("Acquire a cup of water -- details TBD");

            Console.WriteLine("\nAcquire the items above, then press any key\n");
            Console.ReadKey();

            Console.WriteLine("CALL PROCEDURE 'Apply toothpaste to (the toothbrush we just acquired)'");

            Console.WriteLine("Open mouth");
            Console.WriteLine("Place the toothpaste that is on the bristles against your teeth");
            Console.WriteLine("Move the toothbrush back and forth horizontally on the teeth");
            Console.WriteLine("Iterate motion over all the (exposed surfaces of the) teeth for two minutes, total");
            Console.WriteLine("Brush the tongue for 30 seconds, until you gag");

            Console.WriteLine("\nWhen you are done gagging, press any key\n");
            Console.ReadKey();

            Console.WriteLine("Remove toothbrush from your mouth");
            Console.WriteLine("Put down the toothbrush.");
            Console.WriteLine("Rinse the toothpaste out of your mouth USING a 'cup of water' and into the LiquidWasteReceptacle");
            Console.WriteLine("Close mouth");

            Console.WriteLine("\nCALL PROCEDURE 'Put away Toothpaste and Toothbrush (Toothpaste tube we are using, Toothbrush we are using)'");


            Console.WriteLine("\nPress a key to View 'Apply toothpaste to (toothbrush)' procedure\n\n");
            Console.ReadKey();

            Console.WriteLine("PROCEDURE 'Apply toothpaste to (toothbrush)'");
	            Console.WriteLine("Acquire toothpaste tube -- details TBD");
	
	            Console.WriteLine("Pick up your toothpaste with one hand");
	            Console.WriteLine("Unscrew the top");
	            Console.WriteLine("Put the top down");

	            Console.WriteLine("Pick up your toothbrush with the other hand");
	            Console.WriteLine("Align the bristles of the toothbraush with the opening of the toothpaste tube");
	            Console.WriteLine("Make sure the bristles are pointing up");
	            Console.WriteLine("Make sure that the toothbrush is below the toothpaste");
	            Console.WriteLine("Gently squeeze a small amount of the toothpaste onto the toothbrush");
	            Console.WriteLine("	'small' -- the same size as the length and width of the bristles");
	            Console.WriteLine("Pick up the toothpaste cap");
	            Console.WriteLine("Put the cap back on the toothpaste");
	            Console.WriteLine("Put the toothpaste tube down");
                Console.WriteLine("END");

            Console.WriteLine("\nPress a key to View 'Put away Toothpaste and Toothbrush' procedure\n\n");
               Console.ReadKey();
                Console.WriteLine("PROCEDURE 'Put away Toothpaste and Toothbrush (Toothpaste tube, Toothbrush)'");
	            Console.WriteLine("Pick up the toothpaste tube");
	            Console.WriteLine("Pick up the toothbrush");
	            Console.WriteLine("Place both in the approved storage area -- details TBD");
                Console.WriteLine("END");

                Console.WriteLine("\nPress a key to End");
                Console.ReadKey();
        }
    }
}
