using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using AppSettings;

namespace Services
{
	public class EmailService
	{
		private readonly SmtpClient _client;

		public EmailService( )
		{
			_client.UseDefaultCredentials = false;
			_client.Credentials = new NetworkCredential(SMTP.user_name, SMTP.password);
			_client.Host = SMTP.host;
			_client.Port = SMTP.port;
			_client.DeliveryMethod = SmtpDeliveryMethod.Network;
			_client.EnableSsl = SMTP.ssl;
		}
	}
}
