using System;

namespace Domain
{
	public class user_information : Entity
	{
		Entity entity = new Entity();
		public string Birthdate { get; set; }
		public string Address { get; set; }

		public user_information(string fname = "Firstname", string lname = "Lastname", int ID = 0, string birthdate = "01/01/2000", string address = "No Address")
		{
			entity.ID = ID;
			entity.Firstname = fname;
			entity.Lastname = lname;
			Address = address;
			Birthdate = birthdate;

		}


	}
}
