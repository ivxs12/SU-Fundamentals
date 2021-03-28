using System;
using System.Linq;
using System.Collections.Generic;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> arr = Console.ReadLine().Trim().Split().Select(double.Parse).ToList();

            SumAdjacent(arr);
        }
        static void SumAdjacent(List<double> input)
        {
            int i = 0;
            while (i < input.Count - 1)
            {
                if (input.ElementAt(i).Equals(input.ElementAt(i + 1)))
                {
                    input[i] += input.ElementAt(i + 1);
                    input.RemoveAt(i + 1);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
