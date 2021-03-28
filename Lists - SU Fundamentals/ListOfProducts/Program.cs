using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Products(n);
        }
        static void Products(int number)
        {
            List<string> products = new List<string>();
            for (int i = 1; i <= number; i++)
            {
                products.Add(Console.ReadLine());
                products.Sort();
            }
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i}.{products[i - 1]}");
            }
        }
    }
}
