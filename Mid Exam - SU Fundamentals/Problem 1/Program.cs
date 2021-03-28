using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorker = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingFactory = int.Parse(Console.ReadLine());
            double sum = 0;
            double precentage = 0;

            for (int i = 0; i < 30; i++)
            {
                if (i % 3 == 0)
                {
                    sum += Math.Floor((biscuitsPerWorker * workers) * 0.75);
                }
                else
                {
                    sum += biscuitsPerWorker * workers;
                }
            }
            Console.WriteLine($"You have produced {sum} biscuits for the past month.");
            if (competingFactory > sum)
            {
                precentage = ((competingFactory - sum) / competingFactory) * 100;
                Console.WriteLine($"You produce {precentage:f2} percent less biscuits.");
            }
            else
            {
                precentage = ((sum - competingFactory) / competingFactory) * 100;
                Console.WriteLine($"You produce {precentage:f2} percent more biscuits.");
            }
        }
    }
}
