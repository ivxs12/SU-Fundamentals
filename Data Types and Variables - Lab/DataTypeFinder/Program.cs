using System;

namespace DataTypeFinder
{
	class Program
	{
		public static void Main()
		{
			string comm = "";
			while (comm != "END")
			{
				comm = Console.ReadLine();
				int value;
				double value2;
				bool value3;
				char value5;
				if (int.TryParse(comm, out value))
				{
					Console.WriteLine(comm + " is integer type");
				}
				else if (comm == "END")
				{
					return;
				}
				else if (double.TryParse(comm, out value2))
				{
					Console.WriteLine(comm + " is floating point type");
				}
				else if (bool.TryParse(comm, out value3))
				{
					Console.WriteLine(comm + " is boolean type");
				}
				else if (char.TryParse(comm, out value5))
				{
					Console.WriteLine(comm + " is character type");
				}
				else if (comm.Length > 1 && int.TryParse(comm, out value) == false)
				{
					Console.WriteLine(comm + " is string type");
				}
			}
		}
	}
}
