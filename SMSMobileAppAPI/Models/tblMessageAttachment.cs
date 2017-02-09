using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblMessageAttachment
    {
        public long Id { get; set; }
        public long FromId { get; set; }
        public byte[] Attachments { get; set; }
        public long OrgId { get; set; }
        public virtual tblMessageCenter tblMessageCenter { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
