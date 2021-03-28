using System;

namespace ConcatNames
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
            Console.Write($"{n[0]}{n[2]}{n[1]}");
        }
    }
}
