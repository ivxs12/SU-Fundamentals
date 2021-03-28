using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            decimal days = Math.Floor(years * 365.2422M);
            decimal hours = days * 24M;
            decimal mins = hours * 60M;
            Console.WriteLine($"{centuries:f0} centuries = {years:f0} years = {days:f0} days = {hours:f0} hours = {mins:f0} minutes");
        }
    }
}
