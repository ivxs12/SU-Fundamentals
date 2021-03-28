using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
		public static void Main()
		{
			double[] arr = new double[3];
			for (int i = 0; i < 3; i++)
			{
				double input = double.Parse(Console.ReadLine());
				arr[i] = input;
			}
			Console.WriteLine(ReturnSmallest(arr));

		}
		public static double ReturnSmallest(double[] input)
		{
			double result = Double.MaxValue;
			for (int i = 0; i < 3; i++)
			{
				if (input[i] <= result)
				{
					result = input[i];
				}
			}
			return result;
		}
	}
}
