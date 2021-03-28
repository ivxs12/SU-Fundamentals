using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Trim().Split(":").ToList();
            string[] command = Console.ReadLine().Trim().Split();

            List<string> deck = new List<string>(input.Count);

            while (command[0] != "Ready")
            {
                switch (command[0])
                {
                    case "Add":
                        if (!input.Contains(command[1]))
                        {
                            Console.WriteLine("Card not found.");
                        }
                        else
                        {
                            deck.Add(command[1]);
                        }                       
                        break;
                    case "Insert":
                        if (input.Contains(command[1]) && Convert.ToInt32(command[2]) < deck.Count && Convert.ToInt32(command[2]) > -1)
                        {
                            deck.Insert(Convert.ToInt32(command[2]), command[1]);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;
                    case "Remove":
                        if (deck.Contains(command[1]))
                        {
                            deck.Remove(command[1]);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Swap":
                        deck = Swap(deck, command[1], command[2]);
                        break;
                    case "Shuffle":
                        deck.Reverse();
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Trim().Split();
            }
            Console.WriteLine(String.Join(" ", deck));
        }
        static List<string> Swap(List<string> deck, string card, string cardSecond)
        {
            if (deck.IndexOf(card) < deck.IndexOf(cardSecond))
            {
                deck.Insert(deck.IndexOf(cardSecond) + 1, card);
                deck.Remove(card);
                return deck;
            }
            else
            {
                deck.Insert(deck.IndexOf(card) + 1, cardSecond);
                deck.Remove(cardSecond);
                return deck;
            }
        }
    }
}
