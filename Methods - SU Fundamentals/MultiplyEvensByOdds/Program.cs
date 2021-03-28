using System;
using System.Linq;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string newInput = Math.Abs(input).ToString();
            Console.WriteLine(GetEvenSum(GetEven(newInput)) * GetOddSum(GetOdd(newInput)));
        }
        static string[] GetEven(string input)
        {
            string[] even = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int vOut = Convert.ToInt32(input[i]);
                if (vOut % 2 == 0)
                {
                    even[i] += input[i];
                }
            }
            even.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return even;
        }
        static string[] GetOdd(string input)
        {
            string[] odd = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int vOut = Convert.ToInt32(input[i]);
                if (vOut % 2 != 0)
                {
                    odd[i] += input[i];
                }
            }
            odd.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return odd;
        }
        static int GetOddSum(string[] input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result += Convert.ToInt32(input[i]);
            }
            return result;
        }
        static int GetEvenSum(string[] input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result += Convert.ToInt32(input[i]);
            }
            return result;
        }
    }
}
