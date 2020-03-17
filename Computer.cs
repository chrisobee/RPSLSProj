using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer:Player
    {
        //Member Variables
        Random rand = new Random();

        //Constructor

        //Member Methods
        public override void ChooseOption()
        {
            Console.WriteLine("Press enter to generate AI's choice for this round");
            Console.ReadLine();

            int randIndex = rand.Next(Options.Count);
            choice = Options[randIndex];
            Console.WriteLine($"The Computer chose {choice}");
            Console.ReadLine();
        }
    }
}
