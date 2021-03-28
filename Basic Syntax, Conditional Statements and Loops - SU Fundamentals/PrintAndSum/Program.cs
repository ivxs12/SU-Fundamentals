using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int, int) t1 = (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), 0);

            for (int i = t1.Item1; i <= t1.Item2; i++)
            {
                t1.Item3 += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {t1.Item3}");
        }
    }
}
