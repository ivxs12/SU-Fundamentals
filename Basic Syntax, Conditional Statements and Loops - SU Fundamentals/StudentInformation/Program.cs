using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, int, double) t1 = (Console.ReadLine(), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine($"Name: {t1.Item1}, Age: {t1.Item2}, Grade: {t1.Item3:f2}");
        }
    }
}
