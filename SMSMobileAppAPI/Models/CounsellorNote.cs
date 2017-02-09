using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class CounsellorNote
    {
        public long Id { get; set; }
        public long CounsellorId { get; set; }
        public long StudentId { get; set; }
        public System.DateTime DateOfCounselling { get; set; }
        public string Notes { get; set; }
        public long OrgId { get; set; }
        public virtual tblCounsellor tblCounsellor { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
