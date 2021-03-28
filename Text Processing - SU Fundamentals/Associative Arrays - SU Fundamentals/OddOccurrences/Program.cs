using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Trim().Split().ToArray();

            Dictionary<string, int> input = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!input.ContainsKey(arr[i]))
                {
                    input.Add(arr[i], 1);
                }
                else
                {
                    input[arr[i]] += 1;
                }
            }
            foreach (var str in input)
            {
                if (str.Value % 2 == 0)
                {
                    input.Remove(str.Key);
                }
            }
            Console.WriteLine(String.Join(" ", input.Keys));
        }
    }
}
