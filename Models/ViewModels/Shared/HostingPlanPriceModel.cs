using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.Shared
{
    public class HostingPlanPriceModel
    {
        public int ID { get; set; }
        public int Months { get; set; }
        public decimal Price { get; set; }
    }
}
