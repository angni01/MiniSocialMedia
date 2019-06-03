using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
	public class PostRespository
	{
		public List<status_detail> statusList = new List<status_detail>();
		//status_detail post = new status_detail();
		//ArrayList postList = new ArrayList()
		//{
		//	new status_detail
		//	{
		//		DateTime_posted = "01/01/2014",
		//		status = "Hello World",
		//		ID = 1,
		//		posted_by = "Mermellah Angni"

		//	},

		//};
		public void delete(int ID)
		{
			throw new NotImplementedException();
		}

		public void insert(status_detail status)
		{
			throw new NotImplementedException();
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
