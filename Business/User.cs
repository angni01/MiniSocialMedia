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
		public void AddUsers(user_information user)
		{
			UserRepository.GetUserRepository().userList.Add(user);
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
