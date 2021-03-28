using System;

namespace Articles
{
	public class Program
	{
		public static void Main()
		{
			string[] input = Console.ReadLine().Trim().Split(", ", StringSplitOptions.RemoveEmptyEntries);
			int n = int.Parse(Console.ReadLine());
			Article article = new Article(input[0], input[1], input[2]);

			for (int i = 0; i < n; i++)
			{
				string[] command = Console.ReadLine().Trim().Split(": ", StringSplitOptions.RemoveEmptyEntries);
				switch (command[0])
				{
					case "Rename":
						article.Rename(command[1]);
						break;
					case "ChangeAuthor":
						article.ChangeAuthor(command[1]);
						break;
					case "Edit":
						article.Edit(command[1]);
						break;
					default:
						break;
				}
			}
			Console.WriteLine(article.ToString());
		}
	}
	public class Article
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public string Author { get; set; }

		public Article(string title, string content, string author)
		{
			this.Title = title;
			this.Content = content;
			this.Author = author;
		}

		public void Edit(string content)
		{
			this.Content = content;
		}
		public void ChangeAuthor(string author)
		{
			this.Author = author;
		}
		public void Rename(string title)
		{
			this.Title = title;
		}
		public override string ToString()
		{
			string output = Title + " - " + Content + ": " + Author;
			return output;
		}
	}
}
