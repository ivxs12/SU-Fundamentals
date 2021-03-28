using System;

namespace MiddleCharacters
{
    class Program
    {
		public static void Main()
		{
			string input = Console.ReadLine();
			Console.WriteLine(GetMiddle(input));

		}
		public static string GetMiddle(string input)
		{
			string newHalf = "";
			if (input.Length % 2 == 0)
			{
				for (int i = input.Length / 2 - 1; i < input.Length / 2 + 1; i++)
				{
					newHalf += input[i];

				}
			}
			else
			{
				for (int i = input.Length / 2; i < input.Length / 2 + 1; i++)
				{
					newHalf += input[i];
				}
			}
			return newHalf;
		}
	}
}
