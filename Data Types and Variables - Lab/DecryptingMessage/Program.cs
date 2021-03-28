using System;

namespace DecryptingMessage
{
    class Program
    {
        public static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());
                int AsciiValue = Convert.ToInt32(c) + key;
                result += (char)AsciiValue;
            }
            Console.WriteLine(result);
        }
    }
}
