using System;
using System.Collections.Generic;
using System.Linq;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double> ores = new Dictionary<string, double>();

            while (input != "stop")
            {
                double quantity = double.Parse(Console.ReadLine());
                if (!ores.ContainsKey(input))
                {
                    ores.Add(input, quantity);
                }
                else
                {
                    ores[input] += quantity;
                }
                input = Console.ReadLine();
            }
            foreach (var ore in ores)
            {
                Console.WriteLine($"{ore.Key} -> {ore.Value}");
            }
        }
    }
}
