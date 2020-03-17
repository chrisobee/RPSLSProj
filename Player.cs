using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player
    {
        //Member Variables
        public List<string> Options;
        public int winCounter;
        public string choice;
        public string name;

        //Constructor
        public Player()
        {
            Options = new List<string>() {"Rock", "Paper", "Scissors", "Lizard", "Spock"};
        }
        //Member Methods
        public abstract void ChooseOption();

    }
}
