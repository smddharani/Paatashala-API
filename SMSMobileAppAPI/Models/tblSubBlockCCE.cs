using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblSubBlockCCE
    {
        public long Id { get; set; }
        public long BlockId { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblBlockCCE tblBlockCCE { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
