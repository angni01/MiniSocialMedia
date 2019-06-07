using System;
using Domain;
using Domain.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
	public class User
	{
		private static readonly User _instance = new User();

		public static User GetUser()
		{
			return _instance;
		}
		
		public void ViewProfile(int ID)
		{

		}

		public IEnumerable<user_account> GetAccountInfo(int ID)
		{
			List<user_account> userAccountList = UserAccountRepository.GetUserAccountRepository().SelectByID();
			var result = from user in userAccountList where user.User_informationID == ID select user;

			return result;
		}
		public List<user_information> ViewUsers()
		{
			return UserRepository.GetUserRepository().userList;
		}
		public void AddUser(int ID, string fname, string lname, string bdate, string address, string username, string email, int accountID)
		{
			UserRepository.GetUserRepository().insert(ID, fname, lname, bdate, address);
			UserAccountRepository.GetUserAccountRepository().insert(username, email, accountID, ID);
		}
		public void ViewUserFeed(int ID)
		{
			
		}
		public void EditProfile()
		{

		}
	}
}
