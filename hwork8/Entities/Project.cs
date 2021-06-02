using System;
using System.Collections.Generic;
using System.Text;

namespace hwork8.EF
{
	public class Project
	{
		public int Id { get; set; }

		public string ProjectName { get; set; }
		public string ProjectType { get; set; }
		public string Description { get; set; }


		public List<Art> Arts { get; set; }
	}
}
