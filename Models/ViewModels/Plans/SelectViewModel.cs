using Models.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.Plans
{
    public class SelectViewModel
    {
        public HostingPlanModel HostingPlan { get; set; }
        public int SelectedPriceId { get; set; }
    }
}
