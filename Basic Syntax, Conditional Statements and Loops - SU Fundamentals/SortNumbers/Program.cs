using System;

namespace SortNumbers
{
    class Program
    {
		public static void Main()
		{
			int[] arr = new int[3];
			for (int i = 0; i < 3; i++)
			{
				int n = int.Parse(Console.ReadLine());
				arr[i] += n;
			}
			Array.Sort(arr);
			Array.Reverse(arr);
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}
	}
}
