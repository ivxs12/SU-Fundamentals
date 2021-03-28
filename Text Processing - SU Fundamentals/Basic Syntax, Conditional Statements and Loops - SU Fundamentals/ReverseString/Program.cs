using System;

namespace ReverseString
{
    class Program
    {
		public static void Main()
		{
			char[] comm = Console.ReadLine().ToCharArray();
			Array.Reverse(comm);
			Console.WriteLine(String.Join("", comm));
		}
	}
}
