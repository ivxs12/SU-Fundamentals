using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Trim().Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            arr.Reverse();
            string arr2 = string.Join(" ", arr);
            string[] newArr = arr2.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(String.Join(" ", newArr));
        }
    }
}
