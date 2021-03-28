using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Trim().Split().ToArray();
                switch (command[0])
                {
                    case "Delete":
                        arr = Delete(arr, Convert.ToInt32(command[1]));
                        break;
                    case "Insert":
                        arr = Insert(arr, Convert.ToInt32(command[1]), Convert.ToInt32(command[2]));
                        break;
                    case "end":
                        Console.WriteLine(String.Join(" ", arr));
                        return;
                    default:
                        break;
                }
            }
        }
        static List<int> Delete(List<int> collection, int element)
        {
            return collection = collection.Where(x => x != element).ToList();
        }
        static List<int> Insert(List<int> collection, int element, int position)
        {
            if (position < collection.Count())
            {
                int capacity = collection.Count + 1;
                int[] arr = new int[capacity];
                for (int i = 0; i < position; i++)
                {
                    arr[i] += collection.ElementAt(i);
                }
                arr[position] += element;
                for (int i = position + 1; i < collection.Count; i++)
                {
                    arr[i] += collection.ElementAt(i - 1);
                }
                arr[arr.Length - 1] += collection.ElementAt(collection.Count - 1);
                return arr.ToList();
            }
            return collection;
        }
    }
}
