using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Trim().Split().ToArray();
            string[] arr2 = Console.ReadLine().Trim().Split().ToArray();
            string[] repeat = new string[arr.Length];
            repeat = arr.Where(x => arr2.Contains(x)).ToArray();
            Console.WriteLine(string.Join(" ", repeat));
        }
    }
}
