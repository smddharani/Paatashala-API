using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblDietPlan
    {
        public tblDietPlan()
        {
            this.tblDietPlanDetails = new List<tblDietPlanDetail>();
        }

        public long Id { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblDietPlanDetail> tblDietPlanDetails { get; set; }
    }
}
