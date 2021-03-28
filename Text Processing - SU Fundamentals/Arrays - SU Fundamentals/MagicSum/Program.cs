using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
		public static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
			int num = int.Parse(Console.ReadLine());
			for (int i = 0; i < arr.Length; i++)
			{
				for (int z = i + 1; z < arr.Length; z++)
				{
					if (arr[i] + arr[z] == num)
					{
						Console.WriteLine(arr[i] + " " + arr[z]);
					}
				}
			}
		}
	}
}
