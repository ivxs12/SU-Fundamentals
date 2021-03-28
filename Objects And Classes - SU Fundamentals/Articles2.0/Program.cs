using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
	public class Program
	{
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			List<Article> articles = new List<Article>(n);
			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Trim().Split(", ", StringSplitOptions.RemoveEmptyEntries);
				Article article = new Article(input[0], input[1], input[2]);
				articles.Add(article);
			}
			string sort = Console.ReadLine();
			switch (sort)
			{
				case "title":
					articles = articles.OrderBy(x => x.Title).ToList();
					break;
				case "content":
					articles = articles.OrderBy(x => x.Content).ToList();
					break;
				case "author":
					articles = articles.OrderBy(x => x.Author).ToList();
					break;
			}
			foreach (Article article in articles)
			{
				Console.WriteLine(article.ToString());
			}
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

		public override string ToString()
		{
			string output = Title + " - " + Content + ": " + Author;
			return output;
		}
	}
}
