using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int num = int.Parse(Console.ReadLine());
		Dictionary<string, string> reg = new Dictionary<string, string>();

		for (int i = 0; i < num; i++)
		{
			string[] input = Console.ReadLine().Split();

			if (input[0] == "register")
			{
				if (!reg.ContainsKey(input[1]))
				{
					reg.Add(input[1], input[2]);
					Console.WriteLine($"{input[1]} registered {input[2]} successfully");
				}
				else
				{
					Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
				}
			}
			else if (input[0] == "unregister")
			{
				if (!reg.ContainsKey(input[1]))
				{
					Console.WriteLine($"ERROR: user {input[1]} not found");
				}
				else
				{
					reg.Remove(input[1]);
					Console.WriteLine($"{input[1]} unregistered successfully ");
				}
			}
		}
		foreach (var register in reg)
		{
			Console.WriteLine($"{register.Key} => {register.Value}");
		}
	}
}
