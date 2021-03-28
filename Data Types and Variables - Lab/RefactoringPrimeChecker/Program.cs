using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int num = 2; num <= range; num++)
            {
                bool isPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", num, isPrime.ToString().ToLower());
            }
        }
    }
}
