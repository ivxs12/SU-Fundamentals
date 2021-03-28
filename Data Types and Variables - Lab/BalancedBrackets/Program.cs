using System;

namespace BalancedBrackets
{
    class Program
    {
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string[] arr = new string[n];
			int countOne = 0;
			int countTwo = 0;
			for (int i = 0; i < n; i++)
			{
				arr[i] += Console.ReadLine();
				if (arr[i] == "(")
				{
					countOne++;
				}
				else if (arr[i] == ")")
				{
					countTwo++;
					if (countOne - countTwo != 0)
					{
						Console.WriteLine("UNBALANCED");
						return;
					}
				}
			}
			if (countOne - countTwo == 0)
			{
				Console.WriteLine("BALANCED");
			}
			else
			{
				Console.WriteLine("UNBALANCED");
			}
		}
	}
}
