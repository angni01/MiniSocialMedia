using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
	public sealed class PostRespository
	{
		public List<status_detail> statusList = new List<status_detail>();
		private static readonly PostRespository _instance = new PostRespository();
		status_detail post = new status_detail();

		public static PostRespository GetPostRespository()
		{
			var x = _instance.statusList;
			return _instance;
		}
		public void delete(int ID)
		{
			throw new NotImplementedException();
		}

		public void insert(int ID, string datetime_posted, string status, string posted_by )
		{
			statusList.Add(new status_detail {ID=ID, DateTime_posted = datetime_posted, status = status, posted_by = posted_by });

		}

		public IEnumerable<status_detail> SelectAll()
		{
			throw new NotImplementedException();
		}

		public status_detail SelectbyID(int ID)
		{
			throw new NotImplementedException();
		}

		public void update(status_detail status)
		{
			throw new NotImplementedException();
		}
	}
}
