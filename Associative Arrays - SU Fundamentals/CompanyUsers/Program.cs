using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string[] input = Console.ReadLine().Trim().Split(" -> ");
		SortedDictionary<string, List<string>> register = new SortedDictionary<string, List<string>>();

		while (input[0] != "End")
		{
			if (!register.ContainsKey(input[0]))
			{
				Values val = new Values();
				val.Value = new List<string>();
				register.Add(input[0], val.Value);
				val.Value.Add(input[1]);
			}
			else
			{
				if (!register[input[0]].Contains(input[1]))
				{
					register[input[0]].Add(input[1]);
				}
			}
			input = Console.ReadLine().Trim().Split(" -> ");
		}
		foreach (var reg in register.OrderBy(x => x.Key))
		{
			Console.WriteLine(reg.Key);
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
