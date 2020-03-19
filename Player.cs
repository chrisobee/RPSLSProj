using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        //Member Variables
        public List<Gesture> options;
        public int winCounter;
        public Gesture choice;
        public string name;

        //Constructor
        public Player()
        {
            options = new List<Gesture>()
            {
                new Gesture("Rock", new List<string>(){"Paper","Spock" }),
                new Gesture("Paper", new List<string>(){"Scissors","Lizard"}),
                new Gesture("Scissors", new List<string>(){"Rock","Spock"}),
                new Gesture("Lizard", new List<string>(){"Rock","Scissors"}),
                new Gesture("Spock", new List<string>(){"Lizard","Paper"})
            };

        }
        //Member Methods
        public abstract void ChooseOption();
        public abstract void ChooseName();

    }
}
