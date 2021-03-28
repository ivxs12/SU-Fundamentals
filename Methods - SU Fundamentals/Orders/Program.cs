using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int numOfProducts = int.Parse(Console.ReadLine());
            CalcPrice(product, numOfProducts);
        }
        static void CalcPrice(string comm, int num)
        {
            switch (comm)
            {
                case "coffee":
                    Console.WriteLine($"{num * 1.5:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{num * 2:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{num * 1.4:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{num * 1:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
