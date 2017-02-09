using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblCounsellor
    {
        public tblCounsellor()
        {
            this.CounsellorNotes = new List<CounsellorNote>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<CounsellorNote> CounsellorNotes { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
