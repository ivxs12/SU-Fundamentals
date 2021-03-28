using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comm = Console.ReadLine();
            (double, double) t = (double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Calc(comm, t.Item1, t.Item2);
        }
        static void Calc(string command, double firstNum, double secondNum)
        {
            switch (command)
            {
                case "subtract":
                    Console.WriteLine(firstNum - secondNum);
                    break;
                case "divide":
                    Console.WriteLine(firstNum / secondNum);
                    break;
                case "multiply":
                    Console.WriteLine(firstNum * secondNum);
                    break;
                case "add":
                    Console.WriteLine(firstNum + secondNum);
                    break;
                default:
                    break;
            }
        }
    }
}
