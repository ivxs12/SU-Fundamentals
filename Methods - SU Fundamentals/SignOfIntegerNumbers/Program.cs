using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SignOfNumber();
        }
        static void SignOfNumber()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is postive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
