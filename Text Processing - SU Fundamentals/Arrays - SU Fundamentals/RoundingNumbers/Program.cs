using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Trim().Split().Select(double.Parse).ToArray();

            foreach (var i in arr)
            {
                int rounded = (int)Math.Round(i, MidpointRounding.AwayFromZero);
                Console.WriteLine(i + " => " + rounded);
            }
        }
    }
}
