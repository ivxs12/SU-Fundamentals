using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine(GetArea(a, b));
        }
        static double GetArea(double a, double b)
        {
            return a * b;
        }
    }
}
