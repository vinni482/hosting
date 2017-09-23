using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;

namespace Repositories
{
	public class BaseRepository
	{
		protected HostingEntities _db { get; set; }

		public BaseRepository()
		{
			_db = new HostingEntities();
		}
	}
}
