using System;

namespace PowTwoUntil
{
    /// <summary>
    /// Class that deals with showing powers of 2 to the user.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method where all the code will run.
        /// </summary>
        /// <param name="args">arguments written when running</param>
        static void Main(string[] args)
        {
            //Calling PowersOf2Until5 method twice
            PowersOf2Until5();
            PowersOf2Until5();
            //Calling PowersOf2UntilN method twice with different arguments
            PowersOf2UntilN(0);
            PowersOf2UntilN(7);
        }

        /// <summary>
        /// Method that calls PowersOf2UntilN method with a n of 5
        /// </summary>
        private static void PowersOf2Until5(){
            PowersOf2UntilN(5);
        }

        /// <summary>
        /// Method that prints powers of 2 until a certain number n
        /// </summary>
        /// <param name="n"></param>
        private static void PowersOf2UntilN(int n){
            for (int i = 1; i <= (1 << n); i = i << 1){
                Console.WriteLine(i);
            }
        }
    }
}
