using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace BarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex validLine = new Regex(@"%(?<name>[A-Z][a-z]+)%(?:[^%$|\.]*)<(?<product>\w+)>(?:[^$|%\.]*)\|(?<quantity>\d+)(?:[^$|%\.]*)\|(?:[^$|%\.]*?)(?<price>(?:\d+\.\d+?)|(?:\d+))\$");
            double sum = 0;
            List<Customer> customers = new List<Customer>();

            while (input != "end of shift")
            {
                Match fullLine = validLine.Match(input);
                Customer customer = new Customer();
                customer.Name = fullLine.Groups["name"].Value.ToString();
                customer.Product = fullLine.Groups["product"].Value.ToString();
                if (fullLine.Groups["price"].Value.ToString() != string.Empty && fullLine.Groups["quantity"].Value.ToString() != string.Empty)
                {
                    customer.Price = Convert.ToDouble(fullLine.Groups["quantity"].Value.ToString()) * Convert.ToDouble(fullLine.Groups["price"].Value.ToString());
                    customers.Add(customer);
                    sum += customer.Price;
                }
                input = Console.ReadLine();
            }
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.Name}: {item.Product} - {item.Price:f2}");
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
    }
}
