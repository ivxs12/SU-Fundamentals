using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            short capacity = 0;
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                short liters = short.Parse(Console.ReadLine());
                capacity += liters;
                if (capacity > 255)
                {
                    capacity -= liters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
