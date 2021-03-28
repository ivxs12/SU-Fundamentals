using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int newNum = Convert.ToInt32(n[i].ToString());
                sum += newNum;
            }
            Console.WriteLine(sum);
        }
    }
}
