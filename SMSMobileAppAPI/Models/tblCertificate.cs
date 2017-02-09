using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblCertificate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
