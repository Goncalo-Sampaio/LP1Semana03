using System;

namespace PowTwoUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling PowersOf2Until5 method twice
            PowersOf2Until5();
            PowersOf2Until5();
            //Calling PowersOf2UntilN method twice with different arguments
            PowersOf2UntilN(0);
            PowersOf2UntilN(7);
        }

        //method that calls PowersOf2UntilN method with a n of 5
        private static void PowersOf2Until5(){
            PowersOf2UntilN(5);
        }

        //method that prints powers of 2 until a certain number n
        private static void PowersOf2UntilN(int n){
            for (int i = 1; i <= (1 << n); i = i << 1){
                Console.WriteLine(i);
            }
        }
    }
}
