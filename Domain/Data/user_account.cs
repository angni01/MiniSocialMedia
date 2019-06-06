using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	public class user_account : Entity
	{
		Entity entity = new Entity();
		public string Email { get; set; }
		public string Password { get; set; }

		public int User_informationID { get; set; }

		public user_account(string email = "test@yopmail.com", string username = "test", int ID = 0, int user_informationID = 0)
		{
			entity.ID = ID;
			entity.Username = username;
			Email = email;
			User_informationID = user_informationID;

		}
	}
}
