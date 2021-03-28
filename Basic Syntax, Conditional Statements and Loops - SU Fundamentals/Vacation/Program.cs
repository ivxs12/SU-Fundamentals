using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, string, string) t1 = (int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());

            double totalPrice = 0;

            if (t1.Item3 == "Friday")
            {
                switch (t1.Item2)
                {
                    case "Students":
                        totalPrice += 8.45 * t1.Item1;
                        break;
                    case "Business":
                        totalPrice += 10.90 * t1.Item1;
                        if (t1.Item2 == "Business" && t1.Item1 >= 100)
                        {
                            totalPrice -= 10 * 10.90;
                        }
                        break;
                    case "Regular":
                        totalPrice += 15 * t1.Item1;
                        if (t1.Item2 == "Regular" && t1.Item1 >= 10 && t1.Item1 <= 20)
                        {

                        }
                        break;
                    default:
                        break;
                }
            }
            else if (t1.Item3 == "Saturday")
            {
                switch (t1.Item2)
                {
                    case "Students":
                        totalPrice += 9.80 * t1.Item1;
                        break;
                    case "Business":
                        totalPrice += 15.60 * t1.Item1;
                        if (t1.Item2 == "Business" && t1.Item1 >= 100)
                        {
                            totalPrice -= 10 * 15.60;
                        }
                        break;
                    case "Regular":
                        totalPrice += 20 * t1.Item1;
                        break;
                    default:
                        break;
                }
            }
            else if (t1.Item3 == "Sunday")
            {
                switch (t1.Item2)
                {
                    case "Students":
                        totalPrice += 10.46 * t1.Item1;
                        break;
                    case "Business":
                        totalPrice += 16 * t1.Item1;
                        if (t1.Item2 == "Business" && t1.Item1 >= 100)
                        {
                            totalPrice -= 10 * 16;
                        }
                        break;
                    case "Regular":
                        totalPrice += 22.50 * t1.Item1;
                        break;
                    default:
                        break;
                }
            }

            if (t1.Item2 == "Students" && t1.Item1 >= 30)
            {
                totalPrice -= totalPrice * 15 / 100;
            }
            else if (t1.Item2 == "Regular" && t1.Item1 >= 10 && t1.Item1 <= 20)
            {
                totalPrice -= totalPrice * 5 / 100;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}

