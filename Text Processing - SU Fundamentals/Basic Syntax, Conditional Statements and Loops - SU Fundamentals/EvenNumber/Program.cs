using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            int n = int.Parse(Console.ReadLine());

            while (n % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                goto Start;
            }

            Console.WriteLine($"The number is: {Math.Sqrt(n * n)}");
        }
    }
}
