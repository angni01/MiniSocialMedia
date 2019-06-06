using System;
using Domain;
using Domain.Repository;
using System.Collections.Generic;

namespace Business
{
	public class User
	{
		
		
		public void ViewProfile(int ID)
		{

		}
		public List<user_information> ViewUsers()
		{
			return UserRepository.GetUserRepository().userList;
		}
		public void AddUsers(int ID, string fname, string lname, string bdate, string address, string username, string email, int accountID)
		{
			UserRepository.GetUserRepository().insert(ID, fname, lname, bdate, address);
			UserAccountRepository.GetUserAccountRepository().insert(username, email, accountID, ID);
		}
		public List<status_detail> ViewUserFeed(int ID)
		{
			return PostRespository.GetPostRespository().statusList;
		}
		public void EditProfile()
		{

		}
	}
}
