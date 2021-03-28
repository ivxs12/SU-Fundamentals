using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
		public static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
			for (int i = 0; i < arr.Length; i++)
			{
				int sumFirst = 0;
				int sumSecond = 0;
				for (int z = i + 1; z < arr.Length; z++)
				{
					sumFirst += arr[z];
				}
				for (int z = 0; z < i; z++)
				{
					sumSecond += arr[z];
				}
				if (sumFirst == sumSecond)
				{
					Console.WriteLine(i);
					return;
				}
				else
				{
					sumFirst = 0;
					sumSecond = 0;
				}
			}
			Console.WriteLine("no");
		}
	}
}
