using System;

namespace HeroPerks
{
    class Program
    {
        [Flags]
        enum Perks
        {
            WaterBreathing = 1,
            Stealth = 1,
            AutoHeal = 1,
            DoubleJump = 1
        }

        static void Main(string[] args)
        {
            Perks perks;

            string input = args[0];
            bool unknown = false;

            //Checking if all the inserted perks are known
            foreach(char c in input){
                if (c != 'w' && c != 'a' && c != 's' && c != 'd'){
                    unknown = true;
                }
            }

            //Dealing with unknown perks
            if (unknown == true) {
                Console.WriteLine("Unknown perk!");
            }
        }
    }
}
