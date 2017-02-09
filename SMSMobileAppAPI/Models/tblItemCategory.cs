using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblItemCategory
    {
        public tblItemCategory()
        {
            this.tblItems = new List<tblItem>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblItem> tblItems { get; set; }
    }
}
