using System;

namespace FamousQuotes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("You talking to me?");
            MyPrecious();
            Console.WriteLine("Dodge this");
            Hasta();
        }

        private static void Hasta()
        {
            TheMoney();
            Console.WriteLine("Hasta la vista, baby.");
            MyPrecious();
        }

        private static void TheMoney()
        {
            Console.WriteLine("Show me the money!");
        }

        private static void MyPrecious()
        {
            TheMoney();
            Console.WriteLine("My precious.");
        }
    }
}
