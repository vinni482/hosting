using Models.ViewModels.Home;
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

        public async Task<IndexViewModel> GetHostingPlansAsync()
        {
            IndexViewModel model = new IndexViewModel
            {
                HostingPlans = (await _hostingPlansRepository.GetHostingPlansAsync()).Select(x=>x.ToHostingPlanModel()).ToList()
            };
            return model;
        }
    }
}
