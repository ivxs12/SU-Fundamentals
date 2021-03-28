using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double volumeCurrent = 0;
            string current = "";
            for (int i = 0; i < n; i++)
            { 
                string name = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());
                double volume = Math.PI * (radius * radius) * height;
                if (volumeCurrent < volume)
                {
                    volumeCurrent = volume;
                    current = name;
                }
            }
            Console.WriteLine($"{current}");
        }
    }
}
