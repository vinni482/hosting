using Hosting.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hosting.Models.Home
{
    public class IndexViewModel
    {
        public List<HostingPlanModel> HostingPlans { get; set; }
    }
}