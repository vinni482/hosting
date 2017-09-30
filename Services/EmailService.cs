using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Models.Shared;

namespace Services
{
	public class EmailService
	{
		private readonly SmtpClient _client;

		public EmailService(SMTPModel model)
		{
			_client.UseDefaultCredentials = false;
			_client.Credentials = new NetworkCredential(model.UserName, model.Password);
			_client.Host = model.Host;
			_client.Port = model.Port;
			_client.DeliveryMethod = SmtpDeliveryMethod.Network;
			_client.EnableSsl = model.EnableSSL;
		}
	}
}
