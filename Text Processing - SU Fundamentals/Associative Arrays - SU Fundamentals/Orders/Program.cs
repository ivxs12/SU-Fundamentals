using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            Dictionary<string, List<double>> items = new Dictionary<string, List<double>>();

            while (input[0] != "buy")
            {
                if (!items.ContainsKey(input[0]))
                {
                    Order order = new Order();
                    order.Ord = new List<double>();
                    items.Add(input[0], order.Ord);
                    order.Ord.Add(Convert.ToDouble(input[1]));
                    order.Ord.Add(Convert.ToDouble(input[2]));
                }
                else
                {
                    items[input[0]][0] = Convert.ToDouble(input[1]);
                    items[input[0]][1] += Convert.ToInt32(input[2]);
                }
                input = Console.ReadLine().Trim().Split();
            }
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
    class Order
    {
        public List<double> Ord;
    }
}
