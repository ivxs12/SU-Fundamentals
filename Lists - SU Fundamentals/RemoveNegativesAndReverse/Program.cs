using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            RemoveAndReverse(arr);
        }
        static void RemoveAndReverse(List<int> arr)
        {
            arr = arr.Where(x => x > 0).ToList();
            if (arr.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                arr.Reverse();
                Console.WriteLine(String.Join(" ", arr));
            }
        }
    }
}
