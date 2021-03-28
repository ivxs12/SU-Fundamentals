using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            int passangersPerWagon = int.Parse(Console.ReadLine());
            string comm = "";
            while (comm != "end")
            {
                string[] command = Console.ReadLine().Trim().Split().ToArray();
                comm = command[0];
                switch (command[0])
                {
                    case "Add":
                        arr = Add(arr, Convert.ToInt32(command[1]));
                        break;
                    case "end":
                        break;
                    default:
                        arr = NewPassangers(arr, Convert.ToInt32(command[0]), passangersPerWagon);
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", arr));
        }
        static List<int> Add(List<int> collection, int number)
        {
            int[] arr = new int[collection.Count + 1];
            for (int i = 0; i < collection.Count; i++)
            {
                arr[i] += collection.ElementAt(i);
            }
            arr[collection.Count] += number;
            return arr.ToList();
        }
        static List<int> NewPassangers(List<int> collection, int number, int passangers)
        {
            int remaining = number;
            int[] arr = collection.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < passangers && arr[i] + number <= passangers)
                {
                    arr[i] += number;
                    goto End;
                }
            }
        End:
            return arr.ToList();
        }
    }
}
