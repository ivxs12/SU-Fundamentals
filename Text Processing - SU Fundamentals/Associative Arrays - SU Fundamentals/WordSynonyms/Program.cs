using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> words = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, synonym);
                }
                else
                {
                    if (!words[word].Contains(synonym) && words[word] == "")
                    {
                        words[word] += synonym;
                    }
                    else if (!words[word].Contains(synonym))
                    {
                        words[word] += ", " + synonym;
                    }
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine(word.Key + " - " + String.Join(", ", word.Value));
            }
        }
    }
}
