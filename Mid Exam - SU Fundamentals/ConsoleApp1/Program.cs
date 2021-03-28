using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Trim().Split("|").ToList();
            string[] command = Console.ReadLine().Trim().Split();

            while (command[0] != "Done")
            {
                switch (command[1])
                {
                    case "Left":
                        input = MoveLeft(input, Convert.ToInt32(command[2]));
                        break;
                    case "Right":
                        input = MoveRight(input, Convert.ToInt32(command[2]));
                        break;
                    case "Odd":
                        CheckOdd(input);                        
                        break;
                    case "Even":
                        CheckEven(input);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Trim().Split();
            }
            Console.WriteLine($"You crafted {String.Join("", input)}!");
        }
        static List<string> MoveRight(List<string> input, int index)
        {
            if (index < input.Count && index != input.Count - 1 && index > -1)
            {
                string n = input.ElementAt(index);
                input.RemoveAt(index);
                input.Insert(index + 1, n);
                return input;
            }
            else
            {
                return input;
            }          
        }
        static List<string> MoveLeft(List<string> input, int index)
        {
            if (index < input.Count && index != 0 && index > -1)
            {
                string n = input.ElementAt(index);
                input.RemoveAt(index);
                input.Insert(index - 1, n);
                return input;
            }
            return input;
        }
        static void CheckEven(List<string> input)
        {
            List<string> arr = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    arr.Add(input.ElementAt(i));
                }
            }
            if (arr.Count > 0)
            {
                Console.WriteLine(String.Join(" ", arr));
            }
        }
        static void CheckOdd(List<string> input)
        {
            List<string> arr = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    arr.Add(input.ElementAt(i));
                }
            }
            if (arr.Count > 0)
            {
                Console.WriteLine(String.Join(" ", arr));
            }          
        }
    }
}
