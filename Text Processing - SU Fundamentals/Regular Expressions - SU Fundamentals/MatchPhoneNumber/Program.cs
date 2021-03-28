using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(([+][3][5][9])[-][2][-][0-9]{3}[-][0-9]{4}\b)|(([+][3][5][9])[ ][2][ ][0-9]{3}[ ][0-9]{4}\b)";

            MatchCollection matches = Regex.Matches(input, regex);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
