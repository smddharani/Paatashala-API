using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblNationality
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
