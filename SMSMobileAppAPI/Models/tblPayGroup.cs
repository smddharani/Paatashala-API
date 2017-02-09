using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblPayGroup
    {
        public tblPayGroup()
        {
            this.tblPayGroupDetails = new List<tblPayGroupDetail>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblPayGroupDetail> tblPayGroupDetails { get; set; }
    }
}
