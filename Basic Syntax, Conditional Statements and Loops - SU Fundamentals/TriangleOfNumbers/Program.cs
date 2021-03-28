using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z <= i; z++)
                {
                    Console.Write($"{i + 1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
