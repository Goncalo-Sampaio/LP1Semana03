using System;

namespace HeroPerks
{
    class Program
    {
        //Creating the enum and giving it a Flags attribute to treat it as bits
        [Flags]
        enum Perks
        {
            WaterBreathing = 1 << 0,
            Stealth = 1 << 1,
            AutoHeal = 1 << 2,
            DoubleJump = 1 << 3
        }

        static void Main(string[] args)
        {
            //no perks in the beginning
            Perks perks = 0b0000;

            string input = args[0];
            bool unknown = false;

            //Checking if all the inserted perks are known
            foreach (char c in input)
            {
                if (c != 'w' && c != 'a' && c != 's' && c != 'd')
                {
                    unknown = true;
                    break;
                }
                else
                {
                    //toggle each perk depending on the chars inserted
                    switch (c)
                    {
                        case 'w':
                            perks ^= Perks.WaterBreathing;
                            break;
                        case 'a':
                            perks ^= Perks.AutoHeal;
                            break;
                        case 's':
                            perks ^= Perks.Stealth;
                            break;
                        case 'd':
                            perks ^= Perks.DoubleJump;
                            break;
                        default:
                            break;
                    }
                }
            }

            //Dealing with unknown perks
            if (unknown == true)
            {
                Console.WriteLine("Unknown perk!");
            }
            else
            {
                //Checking if there is any perk to print
                if(perks != 0) {
                    Console.WriteLine(perks);
                }

                //Printing different phrases depending on the perks
                if (perks == 0b0000)
                {
                    Console.WriteLine("No perks at all!");
                }
                if ((perks & Perks.Stealth) == Perks.Stealth && 
                (perks & Perks.DoubleJump) == Perks.DoubleJump)
                {
                    Console.WriteLine("Silent jumper!");
                }
                if ((perks & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }
        }
    }
}
