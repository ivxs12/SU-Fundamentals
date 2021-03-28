using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string final = string.Empty;
            char current = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    final += input[i];
                    current = input[i];
                }
                else if (current != input[i])
                {
                    final += input[i];
                    current = input[i];
                }
            }           
            Console.WriteLine(final);            
        }
    }
}
