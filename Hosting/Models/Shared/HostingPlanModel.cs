using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hosting.Models.Shared
{
    public class HostingPlanModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<FeatureModel> Features { get; set; }
    }
}