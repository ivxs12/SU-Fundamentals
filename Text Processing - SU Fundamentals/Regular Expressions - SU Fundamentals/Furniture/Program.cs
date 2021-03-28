using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rx = new Regex(@"[>]{2}(?<furniture>[A-Za-z]+)[<]{2}(?<price>(?:\d+[.]\d+)|(?:\d+))[!](?<quantity>[\d+])");
            List<Match> matches = new List<Match>();
            double sum = 0;

            while (input != "Purchase")
            {
                Match match = rx.Match(input);
                if (match.Success)
                {
                    matches.Add(match);
                }
                input = Console.ReadLine(); 
            }
            Console.WriteLine("Bought furniture:");
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Groups["furniture"].Value);
                    sum += Convert.ToDouble(match.Groups["price"].Value) * Convert.ToDouble(match.Groups["quantity"].Value);
                }
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
