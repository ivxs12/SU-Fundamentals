using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            char identifier = char.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Calc(first, identifier, second)}");
        }
        static double Calc(double vFirst, char vIdent, double vSecond)
        {
            double result = 0;
            switch (vIdent)
            {
                case '*':
                    result = vFirst * vSecond;
                    break;
                case '/':
                    result = vFirst / vSecond;
                    break;
                case '-':
                    result = vFirst - vSecond;
                    break;
                case '+':
                    result = vFirst + vSecond;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
