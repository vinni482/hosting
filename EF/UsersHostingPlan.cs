//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersHostingPlan
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int HostingPlanID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime NextBillingDate { get; set; }
        public bool Active { get; set; }
    
        public virtual HostingPlan HostingPlan { get; set; }
        public virtual User User { get; set; }
    }
}
