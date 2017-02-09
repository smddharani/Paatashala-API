using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblHostel_Room
    {
        public tblHostel_Room()
        {
            this.tblHostel_Room_Student = new List<tblHostel_Room_Student>();
        }

        public long Id { get; set; }
        public Nullable<long> HostelId { get; set; }
        public Nullable<long> RoomId { get; set; }
        public long OrgId { get; set; }
        public virtual tblHostel tblHostel { get; set; }
        public virtual ICollection<tblHostel_Room_Student> tblHostel_Room_Student { get; set; }
        public virtual tblHostelRoom tblHostelRoom { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
