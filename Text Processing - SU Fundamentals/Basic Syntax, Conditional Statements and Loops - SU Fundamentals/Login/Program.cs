using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            (string, int, int) t2 = ("", username.Length - 1, 0);

            for (int i = 0; i < username.Length; i++)
            {
                t2.Item1 += username[t2.Item2];
                t2.Item2--;
            }
            while (t2.Item3 != 3)
            {
                string password = Console.ReadLine();
                if (password == t2.Item1)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    t2.Item3++;
                }
            }
            Console.WriteLine($"User {username} blocked!");
        }
    }
}
