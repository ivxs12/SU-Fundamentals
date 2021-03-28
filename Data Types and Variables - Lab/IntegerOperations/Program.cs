using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int n = int.Parse(Console.ReadLine());
                arr[i] += n;
            }
            Console.WriteLine(((arr[0] + arr[1]) / arr[2]) * arr[3]);
        }
    }
}
