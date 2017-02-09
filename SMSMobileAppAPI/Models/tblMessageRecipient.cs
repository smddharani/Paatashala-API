using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblMessageRecipient
    {
        public long Id { get; set; }
        public long FromId { get; set; }
        public long ToId { get; set; }
        public bool IsRead { get; set; }
        public long OrgId { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblMessageCenter tblMessageCenter { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
