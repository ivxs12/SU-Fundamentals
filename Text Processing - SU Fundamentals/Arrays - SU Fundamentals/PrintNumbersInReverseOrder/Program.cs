using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNum = new int[n];

            for (int i = n - 1; i > -1; i--)
            {
                int num = int.Parse(Console.ReadLine());
                arrNum[i] += num;
            }
            Console.WriteLine(string.Join(" ", arrNum));
        }
    }
}
