using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, int) t1 = (Console.ReadLine(), int.Parse(Console.ReadLine()));

            if (t1.Item2 <= 18 && t1.Item2 >= 0)
            {
                switch (t1.Item1)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("5$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            if (t1.Item2 <= 64 && t1.Item2 >= 19)
            {
                switch (t1.Item1)
                {
                    case "Weekday":
                        Console.WriteLine("18$");
                        break;
                    case "Weekend":
                        Console.WriteLine("20$");
                        break;
                    case "Holiday":
                        Console.WriteLine("12$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            if (t1.Item2 <= 122 && t1.Item2 >= 65)
            {
                switch (t1.Item1)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("10$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            if (t1.Item2 < 0 || t1.Item2 > 122)

            {
                Console.WriteLine("Error!");
            }

        }
    }
}
