using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, n));
        }
        static string RepeatString(string text, int times)
        {
            string start = "";
            for (int i = 0; i < times; i++)
            {
                start += text;
            }
            return start;
        }
    }
}
