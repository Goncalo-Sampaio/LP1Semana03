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
        }
    }
}
