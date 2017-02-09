using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblMessageCenter
    {
        public tblMessageCenter()
        {
            this.tblMessageAttachments = new List<tblMessageAttachment>();
            this.tblMessageRecipients = new List<tblMessageRecipient>();
        }

        public long Id { get; set; }
        public long EmpId { get; set; }
        public string MessageBody { get; set; }
        public string MessageTitle { get; set; }
        public System.DateTime SentDate { get; set; }
        public long OrgId { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual ICollection<tblMessageAttachment> tblMessageAttachments { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblMessageRecipient> tblMessageRecipients { get; set; }
    }
}
