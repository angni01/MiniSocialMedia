using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Domain.Repository
{
	public class UserRepository
	{
		public List<user_information> userList = new List<user_information>();
		//user_information user = new user_information();
		//ArrayList userList = new ArrayList()
		//{
		//	new user_information
		//	{
		//		ID = 1,
		//		Firstname = "Mermellah",
		//		Lastname = "Angni",
		//		Birthdate = "12/01/1996",
		//		Address = "113 Makaturing str., Dansalan."
		//	},
						
		//};

		public void delete(int ID)
		{
			throw new NotImplementedException();
		}

		public void insert(user_information user)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<user_information> SelectAll()
		{
			throw new NotImplementedException();
		}

		public user_information SelectbyID(int ID)
		{
			throw new NotImplementedException();
		}

		public void update(user_information user)
		{
			throw new NotImplementedException();
		}
	}
}
