using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int count = input.Length;
            int[] arr = new int[input.Length];
            if (n > input.Length)
            {
                n = n - input.Length;
            }
            for (int i = 0; i < input.Length - n; i++)
            {
                arr[i] = input[i + n];
            }
            for (int z = input.Length - n; z < input.Length; z++)
            {
                arr[z] = input[input.Length - count];
                count--;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
