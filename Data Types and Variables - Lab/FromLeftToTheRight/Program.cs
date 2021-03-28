using System;
using System.Linq;

namespace FromLeftToTheRight
{
    class Program
    {
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				double[] arr = Console.ReadLine().Trim().Split().Select(double.Parse).ToArray();
				if (Convert.ToDouble(arr[0]) < Convert.ToDouble(arr[1]))
				{
					string a = Math.Abs(arr[1]).ToString();
					int sum = 0;
					for (int z = 0; z < a.Length; z++)
					{
						sum += Convert.ToInt32(new string(a[z], 1));
					}
					Console.WriteLine(sum);
				}
				else if (Convert.ToInt64(arr[0]) > Convert.ToInt64(arr[1]))
				{
					string a = Math.Abs(arr[0]).ToString();
					double sum = 0;
					for (int z = 0; z < a.Length; z++)
					{
						sum += Convert.ToInt32(new string(a[z], 1));
					}
					Console.WriteLine(sum);
				}
				else if (Convert.ToDouble(arr[0]) == Convert.ToDouble(arr[1]))
				{
					string a = Math.Abs(arr[0]).ToString();
					double sum = 0;
					for (int z = 0; z < a.Length; z++)
					{
						sum += Convert.ToInt32(new string(a[z], 1));
					}
					Console.WriteLine(sum);
				}
			}
		}
	}
}
