using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblDietPlanDetail
    {
        public long Id { get; set; }
        public long DietId { get; set; }
        public long Item { get; set; }
        public decimal Weight { get; set; }
        public string UOM { get; set; }
        public long Course { get; set; }
        public long OrgId { get; set; }
        public virtual tblCourse tblCourse { get; set; }
        public virtual tblDietaryItem tblDietaryItem { get; set; }
        public virtual tblDietPlan tblDietPlan { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
