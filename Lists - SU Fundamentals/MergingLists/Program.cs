using System;
using System.Linq;
using System.Collections.Generic;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            List<int> arr2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

            Console.WriteLine(String.Join(" ", Merge(arr, arr2)));
        }
        static List<int> Merge(List<int> first, List<int> second)
        {
            List<int> result = new List<int>(first.Count + second.Count);
            if (first.Count >= second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    result.Add(first.ElementAt(i));
                    if (i < second.Count)
                    {
                        result.Add(second.ElementAt(i));
                    }
                }
            }
            else
            {
                for (int i = 0; i < second.Count; i++)
                {
                    if (i < first.Count)
                    {
                        result.Add(first.ElementAt(i));
                    }
                    result.Add(second.ElementAt(i));
                }
            }
            return result;
        }
    }
}
