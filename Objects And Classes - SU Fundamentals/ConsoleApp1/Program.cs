using System;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int pos = random.Next(input.Length);
                string word = input[i];
                input[i] = input[pos];
                input[pos] = word;
            }
            Console.WriteLine(String.Join("\n", input));
        }
    }
}
