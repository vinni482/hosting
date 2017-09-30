using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.ViewModels.Shared
{
    public class HostingPlanModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<FeatureModel> Features { get; set; }
    }
}