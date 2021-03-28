using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            string[] result = new string[6];
            for (int i = 0; i < 3; i++)
            {
                char n = char.Parse(Console.ReadLine());
                result[count] += n;
                if (count - 1 != 0)
                    result[count - 1] += " ";
                count -= 2;
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
