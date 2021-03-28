using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string firstPart = "";
                string secondPart = "";
                if (input.Length % 2 == 0)
                {
                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        firstPart += input[i];
                    }
                    for (int i = input.Length - 1; i > input.Length / 2 - 1; i--)
                    {
                        secondPart += input[i];
                    }
                    if (firstPart == secondPart)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                if (input.Length % 2 != 0)
                {
                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        firstPart += input[i];
                    }
                    for (int i = input.Length - 1 ; i > input.Length / 2; i--)
                    {
                        secondPart += input[i];
                    }
                    
                    if (firstPart == secondPart)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
