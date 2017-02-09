using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblFeeItemDetail
    {
        public tblFeeItemDetail()
        {
            this.tblCourseFeeDetails = new List<tblCourseFeeDetail>();
            this.tblFeePaidDetails = new List<tblFeePaidDetail>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<long> LedgerGroup { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> RatePerUnit { get; set; }
        public Nullable<long> BillingType { get; set; }
        public Nullable<decimal> StandardRate { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblCourseFeeDetail> tblCourseFeeDetails { get; set; }
        public virtual tblFeeLedgerGroup tblFeeLedgerGroup { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblFeePaidDetail> tblFeePaidDetails { get; set; }
    }
}
