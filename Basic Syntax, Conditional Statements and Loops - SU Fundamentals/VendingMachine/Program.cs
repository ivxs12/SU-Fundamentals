using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string comm = Console.ReadLine();
            double sum = 0;
            while (comm != "Start")
            {
                double num = Convert.ToDouble(comm);
                switch (comm)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        sum += num;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {num}");
                        break;
                }
                comm = Console.ReadLine();
            }
            string comm1 = Console.ReadLine();
            while (comm1 != "End")
            {
                switch (comm1)
                {
                    case "Coke":
                        sum -= 1;
                        if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 1; break; }
                        Console.WriteLine("Purchased coke");
                        break;
                    case "Soda":
                        sum -= 0.8;
                        if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 0.8; break; }
                        Console.WriteLine("Purchased soda");
                        break;
                    case "Crisps":
                        sum -= 1.5;
                        if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 1.5; break; }
                        Console.WriteLine("Purchased crisps");
                        break;
                    case "Water":
                        sum -= 0.7;
                        if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 0.7; break; }
                        Console.WriteLine("Purchased water");
                        break;
                    case "Nuts":
                        sum -= 2.0;
                        if (sum < 0) { Console.WriteLine("Sorry, not enough money"); sum += 2.0; break; }
                        Console.WriteLine("Purchased nuts");
                        break;
                    case "End":
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                comm1 = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
