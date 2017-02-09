using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblIssueList
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<long> LoggedBy { get; set; }
        public Nullable<long> Status { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblLogin tblLogin { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
