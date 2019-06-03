using System;
using Domain;
using Domain.Repository;
using System.Collections.Generic;

namespace Business
{
	public class User
	{
		UserRepository userrepo = new UserRepository();
		PostRespository postrepo = new PostRespository();
		public void ViewProfile(int ID)
		{

		}
		public List<user_information> ViewUsers()
		{
			return userrepo.userList;
		}
		public void AddUsers(user_information user)
		{
			userrepo.userList.Add(user);
		}
		public List<status_detail> ViewUserFeed(int ID)
		{
			return postrepo.statusList;
		}
		public void EditProfile()
		{

		}
	}
}
