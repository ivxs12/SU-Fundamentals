using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrFirst = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int[] arrSecond = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            (int, int) t1 = (-1, 0);
            for (int i = 0; i < arrFirst.Length; i++)
            {
                t1.Item1++;
                if (arrFirst[i] != arrSecond[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {t1.Item1} index");
                    return;
                }
                else
                {
                    t1.Item2 += arrFirst[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {t1.Item2}");
        }
    }
}
