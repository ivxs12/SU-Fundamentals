using System;

namespace BackIn30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int) time = (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            time.Item2 += 30;
            if (time.Item2 >= 59)
            {
                time.Item1 += 1;
                time.Item2 -= 60;
            }
            if (time.Item1 > 23)
            {
                time.Item1 -= time.Item1;
            }
            if (time.Item2 <= 9)
            {
                Console.WriteLine($"{time.Item1}:0{time.Item2}");
            }
            else
            {
                Console.WriteLine($"{time.Item1}:{time.Item2}");
            }

        }
    }
}
