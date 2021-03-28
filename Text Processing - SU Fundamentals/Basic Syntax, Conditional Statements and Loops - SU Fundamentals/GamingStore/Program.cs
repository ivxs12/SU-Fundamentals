using System;

namespace GamingStore
{
    class Program
    {
		public static void Main()
		{
			double balance = double.Parse(Console.ReadLine());
			double spent = 0;
			string comm = "";
			while (comm != "Game Time")
			{
				comm = Console.ReadLine();
				if (balance == 0)
				{
					Console.WriteLine("Out of money!");
					return;
				}
				switch (comm)
				{
					case "OutFall 4":
						if (balance - 39.99 < 0)
						{
							Console.WriteLine("Too Expensive");
						}
						else
						{
							balance -= 39.99;
							spent += 39.99;
							Console.WriteLine("Bought OutFall 4");
						}
						break;
					case "CS: OG":
						if (balance - 15.99 < 0)
						{
							Console.WriteLine("Too Expensive");
						}
						else
						{
							balance -= 15.99;
							spent += 15.99;
							Console.WriteLine("Bought CS: OG");
						}
						break;
					case "Zplinter Zell":
						if (balance - 19.99 < 0)
						{
							Console.WriteLine("Too Expensive");
						}
						else
						{
							balance -= 19.99;
							spent += 19.99;
							Console.WriteLine("Bought Zplinter Zell");
						}
						break;
					case "Honored 2":
						if (balance - 59.99 < 0)
						{
							Console.WriteLine("Too Expensive");
						}
						else
						{
							balance -= 59.99;
							spent += 59.99;
							Console.WriteLine("Bought Honored 2");
						}
						break;
					case "RoverWatch":
						if (balance - 29.99 < 0)
						{
							Console.WriteLine("Too Expensive");
						}
						else
						{
							balance -= 29.99;
							spent += 29.99;
							Console.WriteLine("Bought RoverWatch");
						}
						break;
					case "RoverWatch Origins Edition":
						if (balance - 39.99 < 0)
						{
							Console.WriteLine("Too Expensive");
						}
						else
						{
							balance -= 39.99;
							spent += 39.99;
							Console.WriteLine("Bought RoverWatch Origins Edition");
						}
						break;
					case "Game Time":
						break;
					default:
						Console.WriteLine("Not Found");
						break;
				}
			}
			Console.WriteLine("Total spent: $" + spent + ". Remaining: $" + Math.Round(balance, 2));
		}
	}
}
