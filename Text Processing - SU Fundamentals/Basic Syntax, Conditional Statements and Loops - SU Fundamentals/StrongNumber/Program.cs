using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, int, int) t1 = (Console.ReadLine(), 0, 0);

            for (int i = 0; i < t1.Item1.Length; i++)
            {
                int currentNum = Convert.ToInt32(t1.Item1[i].ToString());
                t1.Item2 = currentNum;
                for (int z = currentNum - 1; z >= 1; z--)
                {
                    t1.Item2 = t1.Item2 * z;
                }
                t1.Item3 += t1.Item2;
                t1.Item2 = 0;
            }
            if (t1.Item3 == Convert.ToInt32(t1.Item1))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
