using System;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int type = int.Parse(Console.ReadLine());
            Console.WriteLine(ToBinary(n, type));
        }
        static int ToBinary(int num, int type)
        {
            int sum = 0;
            string binary = Convert.ToString(num, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (type == 0 && binary[i] == '0')
                {
                    sum++;
                }
                else if (type == 1 && binary[i] == '1')
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
