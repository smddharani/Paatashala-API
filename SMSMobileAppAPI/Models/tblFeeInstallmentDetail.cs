using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblFeeInstallmentDetail
    {
        public long Id { get; set; }
        public Nullable<long> CourseId { get; set; }
        public Nullable<long> InstallmentOrder { get; set; }
        public Nullable<long> DurationDays { get; set; }
        public Nullable<decimal> MinFeeAmount { get; set; }
        public long OrgId { get; set; }
        public virtual tblCourse tblCourse { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
