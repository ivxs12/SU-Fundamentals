using System;
using System.Linq;
using System.Collections.Generic;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

            Gauss(arr);
        }
        static void Gauss(List<int> input)
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                input[i] += input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
