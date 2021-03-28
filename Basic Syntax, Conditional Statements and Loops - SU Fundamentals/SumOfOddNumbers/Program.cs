using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;
            int d = 0;
            for (int z = d; z <= n * 2; z++)
            {
                if (z % 2 != 0)
                {
                    sum += z;
                    d += z + 1;
                    Console.WriteLine(z);
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
