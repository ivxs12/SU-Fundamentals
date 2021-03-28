using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Regex rgx = new Regex(@"^[A-Za-z-_\d]+$");
            List<Match> matches = new List<Match>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length >= 3 && input[i].Length <= 16)
                {
                    Match match = rgx.Match(input[i]);
                    matches.Add(match);
                }
            }
            matches = matches.Where(x => x != Match.Empty).ToList();
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
