using Models.Shared;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HostingPlansService
    {
        private readonly HostingPlansRepository _hostingPlansRepository;

        public HostingPlansService()
        {
            _hostingPlansRepository = new HostingPlansRepository();
        }

        public async Task<List<HostingPlanModel>> GetHostingPlansAsync()
        {
            return (await _hostingPlansRepository.GetHostingPlansAsync()).Select(x => x.ToHostingPlanModel()).ToList();
        }

        public async Task<HostingPlanModel> GetHostingPlanByIdAsync(int id)
        {
            return (await _hostingPlansRepository.GetHostingPlanByIdAsync(id)).ToHostingPlanModel();
        }
    }
}
