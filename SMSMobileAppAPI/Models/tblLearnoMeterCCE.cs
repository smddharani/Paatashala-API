using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblLearnoMeterCCE
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long TermId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblTermCCE tblTermCCE { get; set; }
    }
}
