using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
		public static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
			string result = "";
			for (int i = 0; i < arr.Length - 1; i++)
			{
				int count = 0;
				for (int z = i; z < arr.Length; z++)
				{
					if (arr[i] > arr[z])
					{
						count++;
					}
				}
				if (count - (arr.Length - 1 - i) == 0)
				{
					result += arr[i].ToString() + " ";
				}
			}
			result += arr[arr.Length - 1];

			Console.WriteLine(result);
		}
	}
}
