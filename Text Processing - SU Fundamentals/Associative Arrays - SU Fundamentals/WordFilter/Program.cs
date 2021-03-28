﻿using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split().ToArray();

            input = input.Where(x => x.Length % 2 == 0).ToArray();

            Console.WriteLine(String.Join("\n", input));
        }
    }
}
