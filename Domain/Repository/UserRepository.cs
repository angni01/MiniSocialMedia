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
