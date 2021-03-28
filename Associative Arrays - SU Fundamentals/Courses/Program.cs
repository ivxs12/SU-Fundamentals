using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string[] input = Console.ReadLine().Trim().Split(" : ");
		Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

		while (input[0] != "end")
		{
			if (!register.ContainsKey(input[0]))
			{
				Values values = new Values();
				values.Value = new List<string>();
				register.Add(input[0], values.Value);
				values.Value.Add(input[1]);
			}
			else if (register.ContainsKey(input[0]))
			{
				register[input[0]].Add(input[1]);
			}
			input = Console.ReadLine().Trim().Split(" : ");
		}
		foreach (var reg in register.OrderByDescending(x => x.Value.Count))
		{
			Console.WriteLine(reg.Key + ": " + reg.Value.Count);
			reg.Value.Sort();
			foreach (var item in reg.Value)
			{
				Console.WriteLine("-- " + item);
			}
		}
	}
}
public class Values
{
	public List<string> Value;
}
