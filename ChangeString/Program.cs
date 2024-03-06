using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to input a string
            Console.Write("Please write a string: ");
            string input = Console.ReadLine();
            //Asking the user to input a char
            Console.Write("Please insert a char: ");
            char charInput = char.Parse(Console.ReadLine());
        }
    }
}
