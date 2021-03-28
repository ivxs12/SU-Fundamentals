using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int) t1 = (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            for (int i = t1.Item1; i <= t1.Item2; i++)
            {
                char c = Convert.ToChar(i);
                Console.Write(c + " ");
            }
        }
    }
}
