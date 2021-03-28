using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            for (int z = 0; z < arr.Length - 1; z++)
            {
                int[] condense = new int[arr.Length];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    condense[i] = arr[i] + arr[i + 1];
                }
                arr = condense;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
