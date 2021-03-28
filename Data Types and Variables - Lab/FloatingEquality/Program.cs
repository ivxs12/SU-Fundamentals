using System;

namespace FloatingEquality
{
    class Program
    {
		public static void Main()
		{
			double numFirst = double.Parse(Console.ReadLine());
			double numSecond = double.Parse(Console.ReadLine());
			double eps = Math.Abs(numFirst - numSecond);

			if (eps > 0.000001)
			{
				Console.WriteLine("False");
			}
			else
			{
				Console.WriteLine("True");
			}
		}
	}
}
