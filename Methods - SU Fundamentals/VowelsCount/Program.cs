using System;

namespace VowelsCount
{
    class Program
    {
		public static void Main()
		{
			string input = Console.ReadLine();
			Console.WriteLine(VowelCount(input));

		}
		public static int VowelCount(string input)
		{
			int count = 0;
			for (int i = 0; i < input.Length; i++)
			{
				switch (input[i].ToString().ToLower())
				{
					case "a":
					case "e":
					case "i":
					case "o":
					case "u":
						count++;
						break;
					default:
						break;
				}
			}
			return count;
		}
	}
}
