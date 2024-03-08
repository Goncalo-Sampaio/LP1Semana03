using System;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to insert number of players
            Console.Write("Please insert the number of players: ");
            string input = Console.ReadLine();
            //saving the input on a int variable n
            int n = int.Parse(input);

            PlayerAchievements [] players = new PlayerAchievements [n];

            //loop to ask each player whats their achievements
            for (int i = 0; i < n; i++){
                PlayerAchievements achievements = 0x000;

                Console.WriteLine($"Player {n}:");
                Console.Write("Defeated Optional Boss? (Enter y to confirm) ");
                string achievement1 = Console.ReadLine();
                if (achievement1 == "y"){
                    achievements ^= PlayerAchievements.DefeatOptionalBoss;
                }
                Console.Write("Found hidden level? (Enter y to confirm) ");
                string achievement2 = Console.ReadLine();
                if (achievement2 == "y"){
                    achievements ^= PlayerAchievements.FindHiddenLevel;
                }
                Console.Write("Finished the game? (Enter y to confirm) ");
                string achievement3 = Console.ReadLine();
                if (achievement3 == "y"){
                    achievements ^= PlayerAchievements.FinishGame;
                }

                players[i] = achievements;
            } 
        }
    }
}
