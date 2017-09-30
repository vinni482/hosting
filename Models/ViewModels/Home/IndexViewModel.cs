using Models.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.ViewModels.Home
{
    public class IndexViewModel
    {
        public List<HostingPlanModel> HostingPlans { get; set; }
    }
}