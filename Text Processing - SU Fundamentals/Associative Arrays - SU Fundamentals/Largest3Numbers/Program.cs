using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            arr = arr.OrderByDescending(x => x).ToArray();
            if (arr.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
