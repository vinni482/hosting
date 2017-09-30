using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Models.Shared;
using AppSettings;

namespace Hosting.Controllers
{
    public class BaseController : Controller
    {
		private Services.EmailService _emailService;


		public Services.EmailService EmailSender
		{
			get
			{
				_emailService = _emailService ?? new Services.EmailService(new SMTPModel()
				{
					Host = GetAppSettingString(SMTP.host),
					Port = GetAppSettingInt(SMTP.port),
					EnableSSL = GetAppSettingBool(SMTP.enable_ssl),
					UserName = GetAppSettingString(SMTP.user_name),
					Password = GetAppSettingString(SMTP.password),
				});
				return _emailService;
			}
		}

		protected bool GetAppSettingBool(string name)
		{
			// bool values save in db as 1 && 0
			return ConfigurationManager.AppSettings[name] == "1";
		}
		protected int GetAppSettingInt(string name)
		{
			int result = -1;
			int.TryParse(ConfigurationManager.AppSettings[name], out result);
			return result;
		}
		protected string GetAppSettingString(string name)
		{
			return ConfigurationManager.AppSettings[name];
		}

    }
}