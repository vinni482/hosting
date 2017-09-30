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
        }

        public async Task<HostingPlan> GetHostingPlanByIdAsync(int id)
        {
            return await _db.HostingPlans.Include(x => x.Features).Include(x => x.HostingPlansPrices).Where(x => x.Active == true && x.ID == id).FirstOrDefaultAsync();
        }
    }
}
