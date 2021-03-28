using System;

namespace AddAndSubtract
{
    class Program
    {
		public static void Main()
		{
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			int third = int.Parse(Console.ReadLine());
			Console.WriteLine(SubSecondPair(SumFirstTwo(first, second), third));
		}
		public static int SumFirstTwo(int first, int second)
		{
			return first + second;
		}
		public static int SubSecondPair(int first, int second)
		{
			return first - second;
		}
	}
}
