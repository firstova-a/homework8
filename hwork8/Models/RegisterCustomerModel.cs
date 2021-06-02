using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hwork8.Models
{
	public class RegisterCustomerModel
	{
		public string Login { get; set; }
		public string Password { get; set; }
		public string ContactEmail { get; set; }
		public string ContactPhone { get; set; }
		public string FIO { get; set; }
	}
}
