using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //Member Variable
        Player playerOne;
        Player playerTwo;
        public bool isGamePvP;
        //Constructor

        //Member Methods
        public void RunGame()
        {
            ChooseGameType();
            if(isGamePvP == true)
            {
                while(playerOne.winCounter < 3 && playerTwo.winCounter < 3)
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
            else
            {
                while(playerOne.winCounter < 3 && playerTwo.winCounter < 3)
                {
                    Console.WriteLine("-----------------------------");
                    playerOne.ChooseOption();
                    playerTwo.ChooseOption();

                    CompareChoices(playerOne.choice, playerTwo.choice);
                    Console.WriteLine($"{playerOne.name}'s Score: {playerOne.winCounter} wins");
                    Console.WriteLine($"Computer's Score: {playerTwo.winCounter} wins");
                }

                CheckGameWinner();
            }
        }
        
        public void ChooseGameType()
        {
            Console.WriteLine($"Choose whether this game is\n1) Player v. Player\n2) Player v. Computer");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    playerOne = new Human("Player One");
                    playerTwo = new Human("Player Two");
                    isGamePvP = true;
                    break;
                case 2:
                    playerOne = new Human("Player One");
                    playerTwo = new Computer();
                    isGamePvP = false;
                    break;
                default:
                    Console.WriteLine("Please choose one of the options");
                    ChooseGameType();
                    break;
                    
            }
        }
        public void CompareChoices(string playerOneChoice, string playerTwoChoice)
        {
            for (int i = 0; i < playerOne.Options.Count; i++)
            {
                if(playerOneChoice == playerOne.Options[0])
                {
                    RockCheck(playerTwo.choice);
                    break;
                }
                else if(playerOneChoice == playerOne.Options[1])
                {
                    PaperCheck(playerTwo.choice);
                    break;
                }
                else if(playerOneChoice == playerOne.Options[2])
                {
                    ScissorsCheck(playerTwo.choice);
                    break;
                }
                else if(playerOneChoice == playerOne.Options[3])
                {
                    LizardCheck(playerTwo.choice);
                    break;
                }
                else if(playerOneChoice == playerOne.Options[4])
                {
                    SpockCheck(playerTwo.choice);
                    break;
                }
            }
            
        }

        public void CheckGameWinner()
        {
            if(playerOne.winCounter == 3)
            {
                Console.WriteLine("PLAYER ONE WINS THE GAME!!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("PLAYER TWO WINS THE GAME!!!");
                Console.ReadLine();
            }
        }
        public void RockCheck(string playerTwoChoice)
        {
            if (playerTwoChoice == playerTwo.Options[0])
            {
                Console.WriteLine("Both picked Rock. Round is a tie.");
            }
            else if (playerTwoChoice == playerTwo.Options[1])
            {
                Console.WriteLine("Paper covers Rock. Player Two wins round.");
                playerTwo.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[2])
            {
                Console.WriteLine("Rock crushes Scissors. Player One wins round.");
                playerOne.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[3])
            {
                Console.WriteLine("Rock crushes Lizard. Player One wins round.");
                playerOne.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[4])
            {
                Console.WriteLine("Spock vaporizes Rock. Player Two wins round.");
                playerTwo.winCounter++;
            }
        }

        public void PaperCheck(string playerTwoChoice)
        {
            if(playerTwoChoice == playerTwo.Options[0])
            {
                Console.WriteLine("Paper covers Rock. Player One wins round");
                playerOne.winCounter++;
            }
            else if(playerTwoChoice == playerTwo.Options[1])
            {
                Console.WriteLine("Both picked Paper. Round is a tie");
            }
            else if (playerTwoChoice == playerTwo.Options[2])
            {
                Console.WriteLine("Scissors cuts Paper. Player Two wins round");
                playerTwo.winCounter++;
            }
            else if(playerTwoChoice == playerTwo.Options[3])
            {
                Console.WriteLine("Lizard eats Paper. Player Two wins round.");
                playerTwo.winCounter++;
            }
            else if(playerTwoChoice == playerTwo.Options[4])
            {
                Console.WriteLine("Paper disproves Spock. Player One wins round.");
                playerOne.winCounter++;
            }
        }

        public void ScissorsCheck(string playerTwoChoice)
        {
            if (playerTwoChoice == playerTwo.Options[0])
            {
                Console.WriteLine("Rock crushes Scissors. Player Two wins round");
                playerTwo.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[1])
            {
                Console.WriteLine("Scissors cut Paper. Player One wins round.");
                playerOne.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[2])
            {
                Console.WriteLine("Both chose Scissors. Round is a tie.");
            }
            else if (playerTwoChoice == playerTwo.Options[3])
            {
                Console.WriteLine("Scissors decapitate Lizard. Player One wins round.");
                playerOne.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[4])
            {
                Console.WriteLine("Spock smashes Scissors. Player Two wins round.");
                playerTwo.winCounter++;
            }
        }

        public void LizardCheck(string playerTwoChoice)
        {
            if (playerTwoChoice == playerTwo.Options[0])
            {
                Console.WriteLine("Rock crushes Lizard. Player Two wins round");
                playerTwo.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[1])
            {
                Console.WriteLine("Lizard eats Paper. Player One wins round.");
                playerOne.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[2])
            {
                Console.WriteLine("Scissors decapitate Lizard. Player Two wins round.");
                playerTwo.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[3])
            {
                Console.WriteLine("Both chose Lizard. Round is a tie.");
            }
            else if (playerTwoChoice == playerTwo.Options[4])
            {
                Console.WriteLine("Lizard poisons Spock. Player One wins round.");
                playerOne.winCounter++;
            }
        }

        public void SpockCheck(string playerTwoChoice)
        {
            if (playerTwoChoice == playerTwo.Options[0])
            {
                Console.WriteLine("Spock vaporizes Rock. Player One wins the round");
                playerOne.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[1])
            {
                Console.WriteLine("Paper disproves Spock. Player Two wins round.");
                playerTwo.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[2])
            {
                Console.WriteLine("Spock smashes Scissors. Player One wins round.");
                playerOne.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[3])
            {
                Console.WriteLine("Lizard poisons Spock. Player Two wins round.");
                playerTwo.winCounter++;
            }
            else if (playerTwoChoice == playerTwo.Options[4])
            {
                Console.WriteLine("Both chose Spock. Round is a tie");
            }
        }
        
    }
}
