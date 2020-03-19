using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //Member Variable
        public Player playerOne;
        public Player playerTwo;
        //Constructor

        //Member Methods
        public void RunGame()
        {
            DisplayRules();
            ChooseGameType();

            PlayRound();
            
        }

        public void PlayRound()
        {
            while (playerOne.winCounter < 3 && playerTwo.winCounter < 3)
            {
                Console.WriteLine("-----------------------------");
                playerOne.ChooseOption();
                playerTwo.ChooseOption();

                CompareChoices(playerOne.choice, playerTwo.choice);
                Console.WriteLine($"{playerOne.name}'s Score: {playerOne.winCounter} wins");
                Console.WriteLine($"{playerTwo.name}'s Score: {playerTwo.winCounter} wins");
            }

            CheckGameWinner();
        }

        public void DisplayRules()
        {
            Console.WriteLine($"In Rock Paper Scissors Lizard Spock\n" +
                              $"Rock Crushes Scissors\n" +
                              $"Paper Covers Rock\n" +
                              $"Rock Crushes Lizard\n" +
                              $"Lizard Poisons Spock\n" +
                              $"Spock Smashes Scissors\n" +
                              $"Scissors Decapitates Lizard\n" +
                              $"Lizard Eats Paper\n" +
                              $"Paper Disproves Spock\n" +
                              $"Spock Vaporizes Rock\n" +
                              $"-----------------------------");
        }
        
        public void ChooseGameType()
        {
            Console.WriteLine($"Choose whether this game is\n1) Player v. Player\n2) Player v. Computer\n3) Computer v. Computer");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    playerOne = new Human();
                    playerOne.ChooseName();
                    playerTwo = new Human();
                    playerTwo.ChooseName();
                    break;
                case 2:
                    playerOne = new Human();
                    playerOne.ChooseName();
                    playerTwo = new Computer();
                    playerTwo.ChooseName();
                    break;
                case 3:
                    playerOne = new Computer();
                    playerOne.ChooseName();
                    playerTwo = new Computer();
                    do
                    {
                        playerTwo.ChooseName();
                    }
                    while (playerOne.name == playerTwo.name);
                    break;

                default:
                    Console.WriteLine("Please choose one of the options");
                    ChooseGameType();
                    break;
                    
            }
        }
        public void CompareChoices(Gesture playerOneChoice, Gesture playerTwoChoice)
        {
            if(playerOneChoice.type == playerTwoChoice.type)
            {
                Console.WriteLine($"Both chose {playerOneChoice.type}. Round is a tie.");
            }
            else if (playerOneChoice.losesTo.Contains(playerTwoChoice.type))
            {
                Console.WriteLine($"{playerTwoChoice.type} beats {playerOneChoice.type}. {playerTwo.name} wins the round!");
                playerTwo.winCounter++;
            }
            else
            {
                Console.WriteLine($"{playerOneChoice.type} beats {playerTwoChoice.type}. {playerOne.name} wins the round!");
                playerOne.winCounter++;
            }
            
        }

        public void CheckGameWinner()
        {
            if(playerOne.winCounter == 3)
            {
                Console.WriteLine($"{playerOne.name.ToUpper()} WINS THE GAME!!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{playerTwo.name.ToUpper()} WINS THE GAME!!!");
                Console.ReadLine();
            }
        }
        
    }
}
