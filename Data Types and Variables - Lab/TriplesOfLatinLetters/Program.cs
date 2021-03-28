using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + n; i++)
            {
                for (int z = 97; z < 97 + n; z++)
                {
                    for (int y = 97; y < 97 + n; y++)
                    {
                        Console.WriteLine($"{(char)i}{(char)z}{(char)y}");
                    }
                }
            }
        }
    }
}
