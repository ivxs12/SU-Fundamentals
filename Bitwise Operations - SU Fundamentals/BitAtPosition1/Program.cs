using System;

namespace BitAtPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(BitAtPos(n));
        }
        static int BitAtPos(int num)
        {
            string binary = Convert.ToString(num, 2);
            if (binary[binary.Length - 2] == '1')
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
