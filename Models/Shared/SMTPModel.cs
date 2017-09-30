using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Shared
{
	public class SMTPModel
	{
		public string Host { get; set; }
		public int Port { get; set; }
		public bool EnableSSL { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
