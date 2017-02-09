using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblHostelType
    {
        public tblHostelType()
        {
            this.tblHostels = new List<tblHostel>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblHostel> tblHostels { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
