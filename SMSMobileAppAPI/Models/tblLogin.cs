using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblLogin
    {
        public tblLogin()
        {
            this.tblIssueLists = new List<tblIssueList>();
        }

        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long UserId { get; set; }
        public long UserType { get; set; }
        public bool IsActive { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblIssueList> tblIssueLists { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
