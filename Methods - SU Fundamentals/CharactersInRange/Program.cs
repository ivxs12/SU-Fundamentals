using System;
using System.Linq;

namespace CharactersInRange
{
    class Program
    {
		public static void Main()
		{
			char input = char.Parse(Console.ReadLine());
			char input2 = char.Parse(Console.ReadLine());
			Console.WriteLine(String.Join(" ", CharsBetween(input, input2)));
		}
		public static string[] CharsBetween(char first, char second)
		{
			int a = Convert.ToInt32(first);
			int b = Convert.ToInt32(second);
			string[] arr = new string[Math.Abs(b - a)];
			string collection = "";
			if (a < b)
			{
				for (int i = a + 1; i < b; i++)
				{
					char c = (char)i;
					collection += c;
				}
			}
			else
			{
				for (int i = b + 1; i < a; i++)
				{
					char c = (char)i;
					collection += c;
				}
			}
			for (int i = 0; i < collection.Length; i++)
			{
				arr[i] = collection[i].ToString();
			}
			return arr = arr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
		}
	}
}
