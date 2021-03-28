using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = new string[3];
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                n[i] += input;
            }
            Console.WriteLine($"Town {n[0]} has population of {n[1]} and area {n[2]} square km.");
        }
    }
}
