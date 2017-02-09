using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTimeTable
    {
        public tblTimeTable()
        {
            this.tblTimeTableDetails = new List<tblTimeTableDetail>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long Course { get; set; }
        public long Batch { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblTimeTableDetail> tblTimeTableDetails { get; set; }
    }
}
