using System;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Gets the result of the game in the form of GameStatus
            GameStatus result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors
        (string player1, string player2)
        {
            //Parses the arguments of the program
            GameItem item1 = (GameItem) Enum.Parse(typeof(GameItem), player1);
            GameItem item2 = (GameItem) Enum.Parse(typeof(GameItem), player2);
            GameStatus winner;
            if (player1 == player2)
            {
                winner = GameStatus.Draw; // Draw
            }
            else if (((item1 == GameItem.Rock) && (item2 == GameItem.Scissors))
                || ((item1 == GameItem.Scissors) && (item2 == GameItem.Paper))
                || ((item1 == GameItem.Paper) && (item2 == GameItem.Rock)))
            {
                winner = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                winner = GameStatus.Player2Wins; // Player 2 wins
            }

            return winner;
        }
    }
}
