using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK");
            Console.WriteLine($"Press Enter to Start\n-----------------------------");
            Console.ReadLine();         
            Game game = new Game();
            game.RunGame();
        }
    }
}
