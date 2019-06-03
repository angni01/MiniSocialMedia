using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	public class status_detail : Entity
	{
		public string DateTime_posted { get; set; }
		public string status { get; set; }
		public string posted_by { get; set; }
		public string DateTime_updated { get; set; }
	}
}
