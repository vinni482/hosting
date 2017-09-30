using EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class HostingPlansRepository : BaseRepository
    {
        public async Task<List<HostingPlan>> GetHostingPlansAsync()
        {
            return await _db.HostingPlans.Include(x => x.Features).Include(x => x.HostingPlansPrices).Where(x => x.Active == true).ToListAsync();
            //return await _db.HostingPlans.Where(x => x.Active == true).ToListAsync();
        }
    }
}
