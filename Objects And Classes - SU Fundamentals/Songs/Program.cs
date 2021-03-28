using System;
using System.Linq;
using System.Collections.Generic;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>(n);
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Trim().Split("_").ToArray();
                Song song = new Song()
                {
                    TypeList = input[0],
                    Name = input[1],
                    Time = input[2]
                };
                songs.Add(song);
            }
            string collection = Console.ReadLine();
            if (collection == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                songs = songs.Where(x => x.TypeList == collection).ToList();
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
