using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
    class Program
    {
		public static void Main()
		{
			string pass = Console.ReadLine();
			if (LengthCheck(pass) == true && Consists(pass) == true && DigitValidator(pass) == true)
			{
				Console.WriteLine("Password is valid");
			}
			if (LengthCheck(pass) == false)
			{
				Console.WriteLine("Password must be between 6 and 10 characters");
			}
			if (Consists(pass) == false)
			{
				Console.WriteLine("Password must consist only of letters and digits");
			}
			if (DigitValidator(pass) == false)
			{
				Console.WriteLine("Password must have at least 2 digits");
			}
		}
		public static bool LengthCheck(string input)
		{
			bool isTrue = false;
			if (input.Length < 10 && input.Length > 6)
			{
				isTrue = true;
			}
			else
			{
				isTrue = false;
			}
			return isTrue;
		}
		public static bool Consists(string input)
		{
			bool isTrue = false;
			if (Regex.IsMatch(input, @"^[a-zA-Z0-9]+$"))
			{
				isTrue = true;
			}
			return isTrue;
		}
		public static bool DigitValidator(string input)
		{
			bool isTrue = false;
			char[] input2 = input.Where(x => char.IsDigit(x)).ToArray();
			if (input2.Length < 2)
			{
				isTrue = false;
			}
			else
			{
				isTrue = true;
			}
			return isTrue;
		}
	}
}
