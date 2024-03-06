using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop that will go through all the arguments used
            foreach (string s in args)
            {
                //if the length of the argument is bigger than 3
                if (s.Length > 3)
                {
                    //if the argument is bigger than 6, it breaks the loop
                    if (s.Length > 6)
                    {
                        break;
                    }

                    //Writes all the arguments that have a length of 4-6
                    Console.WriteLine(s);
                }
            }
        }
    }
}
