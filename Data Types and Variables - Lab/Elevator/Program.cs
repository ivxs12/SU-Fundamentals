using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            (float, float) t1 = (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine($"{Math.Ceiling(t1.Item1 / t1.Item2)}");
        }
    }
}
