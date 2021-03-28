using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            (byte, byte) num = (byte.Parse(Console.ReadLine()), byte.Parse(Console.ReadLine()));


            for (int i = num.Item2; i <= 10; i++)
            {
                Console.WriteLine($"{num.Item1} X {i} = {num.Item1 * i}");
            }
            if (num.Item2 > 10)
            {
                Console.WriteLine($"{num.Item1} X {num.Item2} = {num.Item1 * num.Item2}");
            }
        }
    }
}
