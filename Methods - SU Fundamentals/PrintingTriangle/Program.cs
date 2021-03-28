using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int z = 1; z <= i; z++)
                {
                    Console.Write(z + " ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i > 0; i--)
            {
                for (int z = 1; z <= i; z++)
                {
                    Console.Write(z + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
