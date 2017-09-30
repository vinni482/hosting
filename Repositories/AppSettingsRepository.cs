using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class AppSettingsRepository : BaseRepository
	{
		public Dictionary<string, string> GetAll()
		{
			return _db.AppSettings.ToDictionary(x => x.Key, x => x.Value);
		}
	}
}
