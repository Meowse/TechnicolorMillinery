using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to brush your teeth:\n"

+ "Acquire LiquidWasteReceptacle\n"
+ "Verify LiquidWasteReceptacle drains\n"
+ "Verify LiquidWasteReceptacle includes water source\n"
+ "Acquire a toothbrush\n"
+ "Apply toothpaste to (the toothbrush we just acquired)\n"
+ "Acquire toothpaste tube \n"
+ "	Verify toothpaste tube contains minimum required grams of toothpaste\n"
+ "		n = nominal amount of toothpaste to brush teeth\n"
+ "		x = plus/minus tolerance for amount of toothpaste necessary to brush teeth\n"
+ " Acquire CupOfWater\n"
+ "	Obtain EmptyCup with volume >= a\n"
+ "		a = amount of water necessary for mouth rinsing after brushing teeth\n"
+ "	Fill EmptyCup with a ounces of water\n"
+ "Position toothbrush\n"
+ "	Pick up toothbrush\n"
+ "	position toothbrush handle in hand so that bristles are perpindicular to gravity\n"
+ "Prepare toothpaste tube\n"
+ "	Determine type of cap common to toothpaste tube (screw, snap-cap, etc.)\n"
+ "	Unhinge or remove toothpaste cap as required.\n"
+ "Align the bristles with the opening of the tube\n"
+ "Make sure the bristles are pointing up\n"
+ "Make sure that the toothbrush is below the toothpaste\n"
+ "Gently squeeze n-x of the toothpaste onto the toothbrush in-line, ensuring toothpaste engages and maintains contact with toothbrush bristles\n"
+ "Recap the toothpaste tube\n"
+ "Put away the toothpaste tube\n"
+ "Open mouth\n"
+ "Place the toothpaste that is on the bristles against your teeth\n"
+ "Move the toothbrush back and forth horizontally on the teeth with m stroke velocity.\n"
+ "	m = minimum stroke velocity to ensure generation of toothplaste lather.\n"
+ "Iterate motion over all the (exposed surfaces of the) teeth for 150 seconds, plus or minus 30 seconds allowable.\n"
+ "Brush the tongue until you gag\n"
+ "Remove toothbrush from your mouth\n"
+ "Pour contents of CupOfWater into open mouth, ensuring contents do not spill out AND swallowing does not occur.\n"
+ "Swish contents of CupofWater in closed mouth for 10 seconds, plus or minus 2 seconds allowable.\n"
+ "Open mouth and eject contents into LiquidWasteReceptacle\n"
+ "Rinse toothbrush using water source feature of LiquidWasteReceptacle\n"
+ "Obtain towel\n"
+ "Wipe mouth using towel");
            Console.ReadKey();
        }
    }
}
