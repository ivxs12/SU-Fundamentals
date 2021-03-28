using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
