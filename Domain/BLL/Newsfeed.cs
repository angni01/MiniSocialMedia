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
		PostRespository postrepo = new PostRespository();
		public List<status_detail> ViewFeeds()
		{
			return postrepo.statusList;
		}
		public void ViewPost(int ID)
		{
		}

		public void AddPost(status_detail status)
		{
			postrepo.statusList.Add(status);
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
