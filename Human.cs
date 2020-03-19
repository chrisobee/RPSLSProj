using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human:Player
    {
        //Member Variables 

        //Constructor
        public Human()
        {

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
                    choice = options[0];
                    break;
                case 2:
                    choice = options[1];
                    break;
                case 3:
                    choice = options[2];
                    break;
                case 4:
                    choice = options[3];
                    break;
                case 5:
                    choice = options[4];
                    break;
                default:
                    Console.WriteLine("Type in one of the options");
                    ChooseOption();
                    break;
            }
        }

        public override void ChooseName()
        {
            Console.WriteLine("Type in this Player's name");
            name = Console.ReadLine();
            Console.WriteLine("-----------------------------");
        }
    }
}
