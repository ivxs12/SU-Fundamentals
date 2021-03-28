using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            int[] numAndPower = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            while (arr.Contains(numAndPower[0]))
            {
                if (arr.IndexOf(numAndPower[0]) - numAndPower[1] < 0)
                {
                    arr.RemoveRange(arr.IndexOf(arr.First()), arr.IndexOf(numAndPower[0]));
                }
                else
                {
                    arr.RemoveRange(arr.IndexOf(numAndPower[0]) - numAndPower[1], numAndPower[1]);
                }
                if (numAndPower[1] + arr.IndexOf(numAndPower[0]) > arr.Count)
                {
                    arr.RemoveRange(arr.IndexOf(numAndPower[0]), arr.Count - arr.IndexOf(numAndPower[0]));
                }
                else
                {
                    arr.RemoveRange(arr.IndexOf(numAndPower[0]) + 1, numAndPower[1]);
                }
                arr.Remove(numAndPower[0]);
            }
            Console.WriteLine(arr.Sum());
        }
    }
}
