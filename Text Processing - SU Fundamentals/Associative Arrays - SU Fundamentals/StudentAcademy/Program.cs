using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		Dictionary<string, List<double>> register = new Dictionary<string, List<double>>();

		for (int i = 0; i < n; i++)
		{
			string input = Console.ReadLine();
			double input2 = double.Parse(Console.ReadLine());

			if (!register.ContainsKey(input))
			{
				Values val = new Values();
				val.Value = new List<double>();
				register.Add(input, val.Value);
				val.Value.Add(input2);
			}
			else
			{
				register[input].Add(input2);
			}
		}
		foreach (var reg in register.OrderByDescending(x => x.Value.Average()))
		{
			if (reg.Value.Average() >= 4.50)
			{
				Console.WriteLine($"{reg.Key} -> {reg.Value.Average():f2}");
			}
		}
	}
}
public class Values
{
	public List<double> Value;
}
