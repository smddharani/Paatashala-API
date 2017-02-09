using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblBranch
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<long> InstId { get; set; }
        public long OrgId { get; set; }
        public virtual tblInstitution tblInstitution { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
