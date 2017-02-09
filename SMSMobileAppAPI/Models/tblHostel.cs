using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblHostel
    {
        public tblHostel()
        {
            this.tblHostel_Room = new List<tblHostel_Room>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public Nullable<long> HostelType { get; set; }
        public string WardenName { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblHostel_Room> tblHostel_Room { get; set; }
        public virtual tblHostelType tblHostelType { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
