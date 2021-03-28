using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            string comm = " ";
            bool check = false;
            while (comm != "end")
            {
                string[] command = Console.ReadLine().Trim().Split().ToArray();
                comm = command[0];
                switch (comm)
                {
                    case "Contains":
                        Contains(arr, Convert.ToInt32(command[1]));
                        break;
                    case "PrintEven":
                        PrintEven(arr);
                        break;
                    case "PrintOdd":
                        PrintOdd(arr);
                        break;
                    case "GetSum":
                        GetSum(arr);
                        break;
                    case "Filter":
                        Filter(arr, command[1], Convert.ToInt32(command[2]));
                        break;
                    case "Add":
                        check = true;
                        arr = Add(arr, Convert.ToInt32(command[1]));
                        break;
                    case "Remove":
                        check = true;
                        arr = Remove(arr, Convert.ToInt32(command[1]));
                        break;
                    case "RemoveAt":
                        check = true;
                        arr = RemoveAt(arr, Convert.ToInt32(command[1]));
                        break;
                    case "Insert":
                        check = true;
                        arr = Insert(arr, Convert.ToInt32(command[1]), Convert.ToInt32(command[2]));
                        break;
                    default:
                        break;
                }
            }
            if (check)
            {
                Console.WriteLine(String.Join(" ", arr));
            }
        }
        static void Contains(List<int> collection, int number)
        {
            foreach (var item in collection)
            {
                if (item == number)
                {
                    Console.WriteLine("Yes");
                    goto End;
                }
            }
            Console.WriteLine("No such number");
        End:;
        }
        static void PrintEven(List<int> collection)
        {
            int[] arr = new int[collection.Count];
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection.ElementAt(i) % 2 == 0)
                {
                    arr[i] += collection.ElementAt(i);
                }
            }
            Console.WriteLine(String.Join(" ", arr.Where(x => x != 0).ToArray()));
        }
        static void PrintOdd(List<int> collection)
        {
            int[] arr = new int[collection.Count];
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection.ElementAt(i) % 2 != 0)
                {
                    arr[i] += collection.ElementAt(i);
                }
            }
            Console.WriteLine(String.Join(" ", arr.Where(x => x != 0).ToArray()));
        }
        static void GetSum(List<int> collection)
        {
            int sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
        static void Filter(List<int> collection, string condition, int number)
        {
            int[] arr = new int[collection.Count];
            switch (condition)
            {
                case ">":
                    for (int i = 0; i < collection.Count; i++)
                    {
                        if (collection.ElementAt(i) > number)
                        {
                            arr[i] += collection.ElementAt(i);
                        }
                    }
                    Console.WriteLine(String.Join(" ", arr.Where(x => x != 0).ToArray()));
                    break;
                case ">=":
                    for (int i = 0; i < collection.Count; i++)
                    {
                        if (collection.ElementAt(i) >= number)
                        {
                            arr[i] += collection.ElementAt(i);
                        }
                    }
                    Console.WriteLine(String.Join(" ", arr.Where(x => x != 0).ToArray()));
                    break;
                case "<=":
                    for (int i = 0; i < collection.Count; i++)
                    {
                        if (collection.ElementAt(i) <= number)
                        {
                            arr[i] += collection.ElementAt(i);
                        }
                    }
                    Console.WriteLine(String.Join(" ", arr.Where(x => x != 0).ToArray()));
                    break;
                case "<":
                    for (int i = 0; i < collection.Count; i++)
                    {
                        if (collection.ElementAt(i) < number)
                        {
                            arr[i] += collection.ElementAt(i);
                        }
                    }
                    Console.WriteLine(String.Join(" ", arr.Where(x => x != 0).ToArray()));
                    break;
                default:
                    break;
            }
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

