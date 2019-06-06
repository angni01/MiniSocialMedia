using Domain;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Business
{
	class Newsfeed
	{
		public List<status_detail> ViewFeeds()
		{
			return PostRespository.GetPostRespository().statusList;
		}
		public void ViewPost(int ID)
		{
		}

		public void AddPost(string datetime_posted, string status, string posted_by)
		{
			int ID = 1;
			postrepo.insert(ID,datetime_posted, status, posted_by);
		}
		public void DeletePost(status_detail status)
		{
			postrepo.statusList.Remove(status);
		}

		public void EditPost(status_detail status)
		{
		}
	}
}
