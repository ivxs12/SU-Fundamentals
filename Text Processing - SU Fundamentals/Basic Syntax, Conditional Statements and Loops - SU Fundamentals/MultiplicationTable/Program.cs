using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
