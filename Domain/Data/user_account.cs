using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	public class user_account : Entity
	{
		public string email { get; set; }
		public string password { get; set; }

		public int user_informationID { get; set; }
	}
}
