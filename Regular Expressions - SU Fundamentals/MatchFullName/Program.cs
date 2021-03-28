using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+[' '][A-Z][a-z]+\b";

            MatchCollection matches = Regex.Matches(input, regex);

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
