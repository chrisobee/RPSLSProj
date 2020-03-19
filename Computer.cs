using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer:Player
    {
        //Member Variables
        Random rand = new Random();
        List<string> aiNames = new List<string>() { "Mike", "Charles", "David", "Brett", "Nevin", "Paul" };

        //Constructor

        //Member Methods
        public override void ChooseOption()
        {
            Console.WriteLine($"Press enter to generate {name}'s choice for this round");
            Console.ReadLine();

            int randIndex = rand.Next(options.Count);
            choice = options[randIndex];
            Console.WriteLine($"{name} chose {choice.type}");
            Console.ReadLine();
        }

        public override void ChooseName()
        {
            Console.WriteLine($"Press Enter to randomly generate Computer's name");
            Console.ReadLine();
            int nameIndex = rand.Next(aiNames.Count);
            name = aiNames[nameIndex];
            Console.WriteLine($"The Computer's name is: {name}\n-----------------------------");
        }
    }
}
