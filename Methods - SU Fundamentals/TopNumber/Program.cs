using System;
using System.Linq;

namespace TopNumber
{
    class Program
    {
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			foreach (var a in FindPalindrome(n))
			{
				Console.WriteLine(a);
			}
		}
		public static int[] FindPalindrome(int input)
		{
			int[] arr = new int[input];
			for (int i = 1; i <= input; i++)
			{

				if (SumOfDigits(i) % 8 == 0)
				{
					foreach (var a in i.ToString())
					{
						if (a % 2 != 0)
						{
							arr[i] = i;
						}
					}
				}
			}
			return arr = arr.Where(x => x != 0).ToArray();
		}
		public static int SumOfDigits(int input)
		{
			int sum = 0;
			string newInput = input.ToString();
			foreach (var a in newInput)
			{
				sum += Convert.ToInt32(a);
			}
			return sum;
		}
	}
}
