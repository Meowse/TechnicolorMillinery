using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brushYourTeeth
{
    class brushingInstruction
    {
        public int StepId;
        public int RequiresTimer;
        public int Duration;
        public string Instruction;
        public brushingInstruction(int StepId, 
                                   int RequiresTimer, 
                                   int Duration, 
                                   string Instruction)
        {
            //constructor bodies for the class
            this.StepId = id;
            this.RequiresTimer = rt;
            this.Duration = dur;
            this.Instruction = ins;
        }
    }
    
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
            //populate instructions list
            List<brushingInstruction> newBrushingInstructionList = new List<brushingInstruction>();


            Console.Read();

        }


    }
}

