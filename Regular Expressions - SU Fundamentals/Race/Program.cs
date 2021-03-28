using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(", ");
            List<Racer> racers = new List<Racer>();
            foreach (var item in input)
            {
                Racer racer = new Racer();
                racer.Name = item;
                racer.Kilometers = 0;
                racers.Add(racer);
            }
            Regex rgxNums = new Regex(@"(\d)");
            Regex rgxChar = new Regex(@"([A-Za-z])");

            string inputRace = Console.ReadLine();

            while (inputRace != "end of race")
            {
                int sum = 0;
                string name = "";
                MatchCollection names = rgxChar.Matches(inputRace);
                MatchCollection nums = rgxNums.Matches(inputRace);
                foreach (var item in nums)
                {
                    sum += Convert.ToInt32(item.ToString());
                }
                foreach (var item in names)
                {
                    name += item.ToString();
                }
                if (racers.Any(x => x.Name == name))
                {
                    racers.ElementAt(racers.FindIndex(x => x.Name == name)).Kilometers += sum;
                }
                inputRace = Console.ReadLine();
            }
            racers = racers.OrderByDescending(x => x.Kilometers).ToList();
            Console.WriteLine($"1st place: {racers.ElementAt(0).Name}");
            Console.WriteLine($"2nd place: {racers.ElementAt(1).Name}");
            Console.WriteLine($"3rd place: {racers.ElementAt(2).Name}");
        }
    }
    class Racer
    {
        public int Kilometers { get; set; }
        public string Name { get; set; }

    }
}
