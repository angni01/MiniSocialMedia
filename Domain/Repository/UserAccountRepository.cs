using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Domain.Repository
{
	public class UserAccountRepository
	{

		private static readonly UserAccountRepository _instance = new UserAccountRepository();
		public List<user_account> userAccountList = new List<user_account>();

		public static UserAccountRepository GetUserAccountRepository()
		{
			return _instance;
		}

		public void delete(int ID)
		{
			throw new NotImplementedException();
		}

		public void insert(string username, string email, int ID, int user_informationID)
		{
			userAccountList.Add(
				new user_account
				{
				ID = ID,
				Username = username,
				Email = email,
				User_informationID = user_informationID
				});
		}

		public IEnumerable<user_account> SelectAll()
		{
			throw new NotImplementedException();
		}

		public user_account SelectbyID(int ID)
		{
			throw new NotImplementedException();
		}

		public void update(user_account user)
		{
			throw new NotImplementedException();
		}
	}
}
