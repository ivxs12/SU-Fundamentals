using System;
using System.Numerics;

namespace MultiplyBigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine(input * input2);

        }
    }
}
