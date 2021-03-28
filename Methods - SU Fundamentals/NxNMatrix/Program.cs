using System;

namespace NxNMatrix
{
    class Program
    {
		public static void Main()
		{
			int input = int.Parse(Console.ReadLine());
			NxN(input);
		}
		public static void NxN(int input)
		{
			for (int i = 0; i < input; i++)
			{
				Console.WriteLine();
				for (int z = 0; z < input; z++)
				{
					Console.Write(input + " ");
				}
			}
		}
	}
}
