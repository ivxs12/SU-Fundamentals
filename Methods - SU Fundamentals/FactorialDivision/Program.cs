using System;

namespace FactorialDivision
{
    class Program
    {
		public static void Main()
		{
			double first = int.Parse(Console.ReadLine());
			double second = int.Parse(Console.ReadLine());
			Console.WriteLine($"{CalFactorial(first, second):f2}");
		}
		public static double CalFactorial(double first, double second)
		{
			double facFirst = first;
			double facSecond = second;
            if (facFirst >= 0)
            {
				for (int i = 1; i < first; i++)
				{
					facFirst *= first - i;
				}
				for (int i = 1; i < second; i++)
				{
					facSecond *= second - i;
				}
			}
			else
            {
				for (int i = 1; i < first; i++)
				{
					facFirst *= first + i;
				}
				for (int i = 1; i < second; i++)
				{
					facSecond *= second + i;
				}
			}
			double result = facFirst / facSecond;

			return result;
		}
	}
}
