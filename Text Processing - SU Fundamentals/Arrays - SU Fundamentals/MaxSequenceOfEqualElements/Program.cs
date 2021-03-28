using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
		public static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
			int newCount = 0;
			int currentBest = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				int currentElement = 0;
				int count = 0;
				for (int z = i; z < arr.Length; z++)
				{
					if (arr[i] == arr[z])
					{
						count++;
						currentElement = arr[i];
						if (count > newCount)
						{
							newCount = count;
							currentBest = currentElement;
						}
					}
					else
					{
						count = 0;
					}
				}
			}
			string n = "";
			for (int i = 0; i < newCount; i++)
			{
				n += currentBest + " ";
			}
			Console.WriteLine(n);
		}
	}
}
