using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblHostelRoom
    {
        public tblHostelRoom()
        {
            this.tblHostel_Room = new List<tblHostel_Room>();
        }

        public long Id { get; set; }
        public Nullable<long> RoomNumber { get; set; }
        public Nullable<long> RoomRent { get; set; }
        public Nullable<int> Beds { get; set; }
        public Nullable<int> TubeLights { get; set; }
        public Nullable<int> Fan { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblHostel_Room> tblHostel_Room { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
