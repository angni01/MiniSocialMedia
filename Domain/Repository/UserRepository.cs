using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Domain.Repository
{
	public class UserRepository
	{

		private static readonly UserRepository _instance = new UserRepository();
		public List<user_information> userList = new List<user_information>();

		public static UserRepository GetUserRepository()
		{
			return _instance;
		}

		public void delete(int ID)
		{
			throw new NotImplementedException();
		}

		public void insert(int ID, string fname, string lname, string bdate, string address)
		{
			userList.Add(
				new user_information
				{
					ID = ID,
					Firstname = fname,
					Lastname = lname,
					Birthdate = bdate,
					Address = address
				});
		}

		public List<user_information> SelectAll()
		{
			return userList;
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
