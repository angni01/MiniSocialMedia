using System;
using Domain;
using Business;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			Newsfeed Newsfeed = Business.Newsfeed.GetNewsfeed();
			Newsfeed.AddPost(0, "Hello World", "Mermellah Angni");
			Newsfeed.AddPost(1, "New post", "Kyla Calpito");
			Newsfeed.AddPost(2, "This is a new post", "Marc Lomio");
			Newsfeed.AddPost(3, "Hello Again", "Aaron Custodio");
			Newsfeed.AddPost(4, "Test", "Melrose Mejidana");
			List<status_detail> feedList = Newsfeed.ViewFeeds();
			var result = from post in feedList select post;
			foreach (var post in result)
			{
				Console.WriteLine("User : {0}\nMessage : {1}\nDate Posted: : {2}\n", post.posted_by, post.status, post.DateTime_posted);
			}
			Console.ReadKey();
		}
	}
}
