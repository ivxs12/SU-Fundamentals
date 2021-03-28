using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split().ToArray();

            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string part = input[i];

                for (int z = 0; z < part.Length; z++)
                {
                    if (!chars.ContainsKey(part[z]))
                    {
                        chars.Add(part[z], 1);
                    }
                    else
                    {
                        chars[part[z]] += 1;
                    }
                }
            }
            foreach (var character in chars)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
