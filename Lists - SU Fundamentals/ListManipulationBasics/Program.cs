using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            string comm = " ";
            while (comm != "end")
            {
                string[] command = Console.ReadLine().Trim().Split().ToArray();
                comm = command[0];
                switch (comm)
                {
                    case "Add":
                        arr = Add(arr, Convert.ToInt32(command[1]));
                        break;
                    case "Remove":
                        arr = Remove(arr, Convert.ToInt32(command[1]));
                        break;
                    case "RemoveAt":
                        arr = RemoveAt(arr, Convert.ToInt32(command[1]));
                        break;
                    case "Insert":
                        arr = Insert(arr, Convert.ToInt32(command[1]), Convert.ToInt32(command[2]));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", arr));
        }
        static List<int> Remove(List<int> collection, int number)
        {
            collection = collection.Where(x => x.Equals(number) != true).ToList();
            return collection;
        }
        static List<int> RemoveAt(List<int> collection, int number)
        {
            return Remove(collection, collection[number]);
        }
        static List<int> Add(List<int> collection, int number)
        {
            if (collection.Count == collection.Capacity)
            {
                int[] collectionNew = new int[collection.Capacity + 1];
                for (int i = 0; i < collection.Count; i++)
                {
                    collectionNew[i] += collection[i];
                }
                collectionNew[collectionNew.Length - 1] += number;
                return collectionNew.ToList();
            }
            else
            {
                collection[collection.Count + 1] += number;
                return collection;
            }
        }
        static List<int> Insert(List<int> collection, int number, int index)
        {
            int capacity = collection.Count + 1;
            int[] collectionNew = new int[capacity];
            Array.Copy(collection.ToArray(), 0, collectionNew, 0, index);
            collectionNew[index] += number;
            Array.Copy(collection.ToArray(), index, collectionNew, index + 1, capacity - (index + 1));
            return collectionNew.ToList();
        }
    }
}
