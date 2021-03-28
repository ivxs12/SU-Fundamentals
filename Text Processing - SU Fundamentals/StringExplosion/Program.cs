using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string final = "";
            char explosion = '>';
            int strenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == explosion)
                {
                    final += input[i];
                    strenght += Convert.ToInt32(input[i + 1].ToString());                   
                }
                else if (strenght == 0)
                {
                    final += input[i];
                }
                else if (strenght > 0)
                {
                    strenght--;
                }
            }
            Console.WriteLine(final);
        }
    }
}
