using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
using Models.ViewModels.Shared;

namespace Services
{
    public static class Converter
    {
        public static FeatureModel ToFeatureModel(this Feature obj)
        {
            return new FeatureModel
            {
                Name = obj.Name
            };
        }

        public static HostingPlanModel ToHostingPlanModel(this HostingPlan obj)
        {
            return new HostingPlanModel
            {
                ID = obj.ID,
                Description = obj.Description,
                Features = obj.Features.Select(x => x.ToFeatureModel()).ToList(),
                Name = obj.Name,
                Price = decimal.Round(obj.HostingPlansPrices.Select(x => x.Price).Min(), 2, MidpointRounding.AwayFromZero)
        };
        }
    }
}
