using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            SortedDictionary<string, int> items = new SortedDictionary<string, int>();
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            items.Add("MOTES", 0);
            items.Add("FRAGMENTS", 0);
            items.Add("SHARDS", 0);

            while (true)
            {
                for (int i = 1; i < input.Length; i+=2)
                {
                    switch (input[i].ToUpper())
                    {
                        case "MOTES":
                            Check(input, items, i);
                            if (items["MOTES"] >= 250)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                items["MOTES"] -= 250;
                                goto End;
                            }
                            break;
                        case "SHARDS":
                            Check(input, items, i);
                            if (items["SHARDS"] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                items["SHARDS"] -= 250;
                                goto End;
                            }
                            break;
                        case "FRAGMENTS":
                            Check(input, items, i);
                            if (items["FRAGMENTS"] >= 250)
                            {
                                Console.WriteLine("Valanyr obtained!");
                                items["FRAGMENTS"] -= 250;
                                goto End;
                            }
                            break;
                        default:
                            Check(input, junk, i, 0);
                            break;
                    }
                }
                input = Console.ReadLine().Trim().Split();
            }
        End:
            var list = items.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.ToLower()}: {items[item]}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
            }
        }
        static void Check(string[] input, SortedDictionary<string, int> items, int i)
        {
            items[input[i].ToUpper()] += Convert.ToInt32(input[i - 1]);
        }
        static void Check(string[] input, SortedDictionary<string, int> items, int i, int overload)
        {
            if (!items.ContainsKey(input[i].ToUpper()))
            {
                items.Add(input[i].ToUpper(), Convert.ToInt32(input[i - 1]));
            }
            else
            {
                items[input[i].ToUpper()] += Convert.ToInt32(input[i - 1]);
            }
        }
    }
}
