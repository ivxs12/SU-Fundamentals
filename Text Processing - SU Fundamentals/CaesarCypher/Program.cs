using System;

namespace CaesarCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string newInput = "";
            foreach (char c in input)
            {
                int newChar = Convert.ToInt32(c) + 3;
                char newC = Convert.ToChar(newChar);
                newInput += newC;
            }
            Console.WriteLine(newInput);
        }
    }
}
