using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            Console.WriteLine(GetMax(dataType, first, second));
        }
        static string GetMax(string type, string first, string second)
        {
            int result = string.CompareOrdinal(first, second);
            string finalResult = "";
            switch (type)
            {
                case "string":
                    if (result > 0)
                    {
                        finalResult = first;
                    }
                    else if (result < 0)
                    {
                        finalResult = second;
                    }
                    break;
                case "int":
                    if (Convert.ToInt32(first) > Convert.ToInt32(second))
                    {
                        finalResult = first;
                    }
                    else
                    {
                        finalResult = second;
                    }
                    break;
                case "char":
                    if (result > 0)
                    {
                        finalResult = first;
                    }
                    else if (result < 0)
                    {
                        finalResult = second;
                    }
                    break;
                default:
                    break;
            }
            return finalResult;
        }
    }
}
