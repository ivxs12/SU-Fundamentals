using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                (double, int) t1 = (i % 10, i / 10);
                switch (t1.Item1 + t1.Item2)
                {
                    case 5:
                    case 7:
                    case 11:
                        Console.WriteLine($"{i} -> True");
                        break;
                    default:
                        Console.WriteLine($"{i} -> False");
                        break;
                }
            }
        }
    }
}
