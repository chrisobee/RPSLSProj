using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human:Player
    {
        //Member Variables 

        //Constructor
        public Human(string name)
        {
            this.name = name;
        }
        //Member Methods
        public override void ChooseOption()
        {
            Console.WriteLine($"Type in {name}'s choice for this round");
            Console.WriteLine($"1) Rock\n2) Paper\n3) Scissors\n4) Lizard\n5) Spock");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    choice =  Options[0];
                    break;
                case 2:
                    choice =  Options[1];
                    break;
                case 3:
                    choice = Options[2];
                    break;
                case 4:
                    choice = Options[3];
                    break;
                case 5:
                    choice = Options[4];
                    break;
                default:
                    Console.WriteLine("Type in one of the options");
                    ChooseOption();
                    break;
            }
        }
    }
}
