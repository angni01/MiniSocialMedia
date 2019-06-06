using Domain;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Business
{
	public class Newsfeed
	{
		private static readonly Newsfeed _instance = new Newsfeed();

		public static Newsfeed GetNewsfeed()
		{
			return _instance;
		}
		public List<status_detail> ViewFeeds()
		{
			return PostRespository.GetPostRespository().statusList;
		}
		public void ViewPost(int ID)
		{
		}

		public void AddPost(int ID, string status, string posted_by)
		{
			PostRespository.GetPostRespository().insert(ID, status, posted_by);
		}
		public void DeletePost(status_detail status)
		{
			PostRespository.GetPostRespository().statusList.Remove(status);
		}

		public void EditPost(status_detail status)
		{
		}
	}
}
