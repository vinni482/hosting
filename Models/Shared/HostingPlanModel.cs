﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.Shared
{
    public class HostingPlanModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<HostingPlanPriceModel> Prices { get; set; }
        public string Description { get; set; }
        public List<FeatureModel> Features { get; set; }
    }
}