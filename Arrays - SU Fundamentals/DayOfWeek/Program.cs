using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            switch (n)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    Console.WriteLine(week[n - 1]);
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}
