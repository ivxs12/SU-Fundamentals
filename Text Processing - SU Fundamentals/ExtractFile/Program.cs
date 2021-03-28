using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split("\\");

            string[] newIn = input.Last().Split(".");
            Console.WriteLine($"File name: {newIn[0]}");
            Console.WriteLine($"File extension: {newIn[1]}");
        }
    }
}
