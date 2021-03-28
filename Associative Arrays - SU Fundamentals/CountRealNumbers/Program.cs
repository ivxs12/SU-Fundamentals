using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Trim().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, double> nums = new SortedDictionary<double, double>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!nums.ContainsKey(arr[i]))
                {
                    nums.Add(arr[i], 1);
                }
                else
                {
                    nums[arr[i]] += 1;
                }
            }
            foreach (var num in nums)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
