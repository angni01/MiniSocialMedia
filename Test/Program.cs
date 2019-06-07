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
			User User = Business.User.GetUser();
			string again = "Y";
			Newsfeed.AddPost(0, "Hello World", "Mermellah Angni");
			Newsfeed.AddPost(1, "New post", "Kyla Calpito");
			Newsfeed.AddPost(2, "This is a new post", "Marc Lomio");
			Newsfeed.AddPost(3, "Hello Again", "Aaron Custodio");
			Newsfeed.AddPost(4, "Test", "Melrose Mejidana");

			while (again == "Y")
			{
				Console.Write("A\tAdd Account\nB\tView Feeds\nC\tLogin\nE\tExit\n\nChoice : ");
				string choice = Console.ReadLine();
				if (choice == "A")
				{

					Console.Write("ID : ");
					int ID = Convert.ToInt32(Console.ReadLine());
					Console.Write("Username : ");
					string username = Console.ReadLine();
					Console.Write("Email : ");
					string email = Console.ReadLine();
					Console.Write("Firstname : ");
					string fname = Console.ReadLine();
					Console.Write("Lastname : ");
					string lname = Console.ReadLine();
					Console.Write("Birthdate : ");
					string bdate = Console.ReadLine();
					Console.Write("Address : ");
					string address = Console.ReadLine();
					User.AddUser(ID, fname, lname, bdate, address, username, email, ID);
					Console.Clear();
					List<user_information> userList = User.ViewUsers();

					var result = from user in userList select user;
					foreach (var user in result)
					{
						Console.WriteLine("Successfully Created!\nID : {0}\nFirsname : {1}\nlastname : {2}\nBirthdate : {3}\nAddress : {4}\n", user.ID, user.Firstname, user.Lastname, user.Birthdate, user.Address);
					}
				}

				if (choice == "B")
				{
					List<status_detail> feedList = Newsfeed.ViewFeeds();
					var result1 = from post in feedList select post;
					foreach (var post in result1)
					{
						Console.WriteLine("User : {0}\nMessage : {1}\nDate Posted: : {2}\n", post.posted_by, post.status, post.DateTime_posted);
					}
					
				}

				if (choice == "C")
				{
					Console.Write("Enter ID : ");
					int LoginID = Convert.ToInt32(Console.ReadLine());
					IEnumerable<user_account> userAccount = User.GetAccountInfo(LoginID);

					foreach (var info in userAccount)
					{
						Console.WriteLine("Welcome!! {0}", info.Username);
					}

					Console.Write("\nA\tAdd Post\nChoice : ");
					string loginMenu = Console.ReadLine();

					if (loginMenu == "A")
					{
						foreach (var info in userAccount)
						{
							string name = info.Firstname + " " + info.Lastname;
							Random rnd = new Random();
							int random = rnd.Next(1, 101);
							Console.Write("Message : ");
							string message = Console.ReadLine();
							Newsfeed.AddPost(random, message, name);
						}

						Console.WriteLine("Successfully Added Post!");
					}
				}

				Console.Write("Do you want to go back to Menu? Y/N : ");
				again = Console.ReadLine();
				Console.Clear();
			}
		}
	}
}
