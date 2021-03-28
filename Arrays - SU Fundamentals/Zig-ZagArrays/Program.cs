using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr[i] = input[0];
                    arr2[i] = input[1];
                }
                else
                {
                    arr2[i] = input[0];
                    arr[i] = input[1];
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
