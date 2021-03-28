using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(n, power));
        }
        static double RaiseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
