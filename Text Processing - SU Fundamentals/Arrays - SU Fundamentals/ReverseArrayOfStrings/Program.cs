using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Trim().Split().ToArray();
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
