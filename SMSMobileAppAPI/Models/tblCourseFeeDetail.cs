using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblCourseFeeDetail
    {
        public long Id { get; set; }
        public string TemplateName { get; set; }
        public long Course { get; set; }
        public long Batch { get; set; }
        public long FeeItem { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> RatePerUnit { get; set; }
        public Nullable<long> BillingType { get; set; }
        public Nullable<decimal> StandardRate { get; set; }
        public decimal Amount { get; set; }
        public long OrgId { get; set; }
        public virtual tblBatch tblBatch { get; set; }
        public virtual tblCourse tblCourse { get; set; }
        public virtual tblFeeItemDetail tblFeeItemDetail { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
