using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tooth_Brush_Instructions
{
    class Program
    {
        static void Main(string[] args)
        {      string[] lines = { "TOOTH BRUSH INSTRUCTIIONS.", 
                                 "",
               "HOW TO BRUSH YOUR TEETH:",
                    "  ",
	                "1.  Acquire LiquidWasteReceptacle", 
	                "2.  Acquire your personal toothbrush",
	                "3.  Acquire partially full toothpaste tube",
                    "4.  Pick up your toothbrush",
                    "5.  Pick up your toothpaste",
                    "6.  Open the toothpaste", 
                    "7.  Align the bristles with the opening of the tube",
                    "8.  Make sure the bristles are pointing up",
                    "9.  Make sure that the toothbrush is below the toothpaste",
                    "10. Gently squeeze enough toothpaste to cover the bristles",
                    "11. Close the toothpaste container",
                    "12. Put the toothpaste tube down",
                    "13. Open mouth wide",
                    "14. Place the toothpaste that is on the bristles against your teeth",
                    "15. Move the toothbrush back and forth horizontally on the teeth",
                    "16. Iterate motion over all the exposed surfaces of the teeth for two minutes",
                    "17. Then brush the interior portion of your teeth",
                    "18. Remove toothbrush from your mouth",
                    "19. Rinse the toothpaste out of your mouth with water and evacuate the contents into the LiquidWasteReceptacle",
                    "",
                    "THAT'S IT !!!",
                    ""};
            // Output the lines using the default newline sequence.
            Console.WriteLine();
            foreach (string line in lines)
                Console.WriteLine(line);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
        
    
