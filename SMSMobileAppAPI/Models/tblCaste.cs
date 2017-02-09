using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblCaste
    {
        public tblCaste()
        {
            this.tblSubCastes = new List<tblSubCaste>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblSubCaste> tblSubCastes { get; set; }
    }
}
