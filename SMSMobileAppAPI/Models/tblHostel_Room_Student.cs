using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblHostel_Room_Student
    {
        public long Id { get; set; }
        public Nullable<long> HostelRoomId { get; set; }
        public Nullable<long> PersonId { get; set; }
        public Nullable<long> PersonType { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<long> BillingType { get; set; }
        public long OrgId { get; set; }
        public virtual tblHostel_Room tblHostel_Room { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
