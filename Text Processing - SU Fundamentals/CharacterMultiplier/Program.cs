using System;
using System.Numerics;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            BigInteger sum = 0;

            if (input.Length == 1)
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    sum += Convert.ToInt32(input[0][i]);
                }
            }
            else if(input[1].Length > input[0].Length)
            {
                for (int i = 0; i < input[1].Length; i++)
                {
                    if (i < input[0].Length)
                    {
                        sum += Convert.ToInt32(input[0][i]) * Convert.ToInt32(input[1][i]);
                    }
                    else
                    {
                        sum += Convert.ToInt32(input[1][i]);
                    }                   
                }
            }
            else if (input[1].Length <= input[0].Length)
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    if (i < input[1].Length)
                    {
                        sum += Convert.ToInt32(input[0][i]) * Convert.ToInt32(input[1][i]);
                    }
                    else
                    {
                        sum += Convert.ToInt32(input[0][i]);
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
