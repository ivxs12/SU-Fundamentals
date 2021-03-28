using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britPound = decimal.Parse(Console.ReadLine());
            decimal dollar = britPound * 1.31M;
            Console.WriteLine($"{dollar:f3}");
        }
    }
}
