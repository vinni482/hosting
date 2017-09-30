using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
	public class AppSettingsService
	{
		private readonly AppSettingsRepository _appSettingsRepository;

		public AppSettingsService()
		{
			_appSettingsRepository = new AppSettingsRepository();
		}

		public IDictionary<string, string> GetAll()
		{
			return _appSettingsRepository.GetAll();
		}
	}
}
