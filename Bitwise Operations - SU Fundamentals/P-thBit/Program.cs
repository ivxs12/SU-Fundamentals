using System;

namespace P_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine(PthBit(n, pos));
        }
        static char PthBit(int num, int position)
        {
            string binary = Convert.ToString(num, 2);
            if (position > binary.Length)
            {
                return '0';
            }
            else
            {
                return binary[binary.Length - 1 - position];
            }
        }
    }
}
